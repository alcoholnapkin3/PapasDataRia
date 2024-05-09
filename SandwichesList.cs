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
    public partial class SandwichesList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
        private readonly ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");

        public SandwichesList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += SandwichesList_Load;

            contextMenuStrip.Items.AddRange(new[] { editMenuItem, deleteMenuItem });

            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            dgvSandwichesList.ContextMenuStrip = contextMenuStrip;
        }

        private void SandwichesList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("SandwichRecipiesWithNames", "CreateSandwichRecipiesView.sql");
            dataLoader.LoadDataFromView("SandwichRecipiesWithNames", dgvSandwichesList);

            dgvSandwichesList.AutoResizeColumnHeadersHeight();
            dgvSandwichesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

            dgvSandwichesList.Columns["id"].HeaderText = "ID";
            dgvSandwichesList.Columns["recipe_name"].HeaderText = "Название";
            dgvSandwichesList.Columns["meat_or_alternative_name"].HeaderText = "Первое мясо/альтернатива";
            dgvSandwichesList.Columns["batter_or_breading_name"].HeaderText = "Первое тесто/панировка";
            dgvSandwichesList.Columns["extra_meat_or_alternative_name"].HeaderText = "Второе мясо/альтернатива";
            dgvSandwichesList.Columns["extra_batter_or_breading_name"].HeaderText = "Второе тесто/панировка";
            dgvSandwichesList.Columns["bun_name"].HeaderText = "Булка";
            dgvSandwichesList.Columns["topping_or_sauce_1st_name"].HeaderText = "Первый ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_2nd_name"].HeaderText = "Второй ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_3rd_name"].HeaderText = "Третий ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_4th_name"].HeaderText = "Четвёртый ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_5th_name"].HeaderText = "Пятый ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_6th_name"].HeaderText = "Шестой ингредиент";
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSandwichesList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSandwichesList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow))
            {
                SandwichForm sandwichForm = new SandwichForm(selectedRow);

                sandwichForm.ShowDialog();
                SandwichesList_Load(null, null);
            }
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSandwichesList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSandwichesList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow) && MessageBox.Show($"Вы уверены, что хотите удалить запись '{selectedRow.Cells[0].Value}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string queryString = String.Concat("DELETE FROM SandwichRecipies WHERE id = '", selectedRow.Cells[0].Value, "'");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    try
                    {
                        Convert.ToString(command.ExecuteNonQuery());
                        //MessageBox.Show("Строка удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSandwichesList.Rows.RemoveAt(selectedRowIndex);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AddSandwichButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SandwichForm addSandwichForm = new SandwichForm();
            addSandwichForm.ShowDialog();
            SandwichesList_Load(null, null);
            this.Show();
        }
    }
}
