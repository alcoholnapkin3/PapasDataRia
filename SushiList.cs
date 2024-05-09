using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapasDataRia
{
    public partial class SushiList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
        private readonly ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
        public SushiList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += SushiList_Load;

            contextMenuStrip.Items.AddRange(new[] { editMenuItem, deleteMenuItem });

            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            dgvSushiList.ContextMenuStrip = contextMenuStrip;
        }

        private void SushiList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("SushiRecipiesWithNames", "CreateSushiRecipiesView.sql");
            dataLoader.LoadDataFromView("SushiRecipiesWithNames", dgvSushiList);

            dgvSushiList.Columns["id"].HeaderText = "ID";
            dgvSushiList.Columns["recipe_name"].HeaderText = "Название";
            dgvSushiList.Columns["rice_name"].HeaderText = "Рис";
            dgvSushiList.Columns["wrap_name"].HeaderText = "Обёртка";
            dgvSushiList.Columns["flipped"].HeaderText = "Перевёрнут?";
            dgvSushiList.Columns["filling_1st_name"].HeaderText = "Первая начинка";
            dgvSushiList.Columns["filling_2nd_name"].HeaderText = "Вторая начинка";
            dgvSushiList.Columns["filling_3rd_name"].HeaderText = "Третья начинка";
            dgvSushiList.Columns["topping_name"].HeaderText = "Топпинг";
            dgvSushiList.Columns["shaker_name"].HeaderText = "Посыпка";
            dgvSushiList.Columns["sauce_name"].HeaderText = "Соус";
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSushiList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSushiList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow))
            {
                SushiForm sushiForm = new SushiForm(selectedRow);
                sushiForm.ShowDialog();
                SushiList_Load(null, null);
            }
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSushiList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSushiList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow) && MessageBox.Show($"Вы уверены, что хотите удалить запись '{selectedRow.Cells[0].Value}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string queryString = String.Concat("DELETE FROM SushiRecipies WHERE id = '", selectedRow.Cells[0].Value, "'");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    try
                    {
                        Convert.ToString(command.ExecuteNonQuery());
                        dgvSushiList.Rows.RemoveAt(selectedRowIndex);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void AddSushiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SushiForm addSushiForm = new SushiForm();
            addSushiForm.ShowDialog();
            SushiList_Load(null, null);
            this.Show();
        }
    }
}
