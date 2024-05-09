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

        private DataTable dataSource;
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

            dataSource = GetDataTableFromDataGridView(dgvSushiList);
            dgvSushiList.AutoResizeColumnHeadersHeight();
            dgvSushiList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);


            dgvSushiList.Columns["id"].HeaderText = "ID";
            dgvSushiList.Columns["id"].Width = 50;
            dgvSushiList.Columns["recipe_name"].HeaderText = "Название";
            dgvSushiList.Columns["recipe_name"].Width = 100;
            dgvSushiList.Columns["rice_name"].HeaderText = "Рис";
            dgvSushiList.Columns["rice_name"].Width = 100;
            dgvSushiList.Columns["wrap_name"].HeaderText = "Обёртка";
            dgvSushiList.Columns["wrap_name"].Width = 100;
            dgvSushiList.Columns["flipped"].HeaderText = "Перевёрнут?";
            dgvSushiList.Columns["flipped"].Width = 70;
            dgvSushiList.Columns["filling_1st_name"].HeaderText = "Первая начинка";
            dgvSushiList.Columns["filling_1st_name"].Width = 100;
            dgvSushiList.Columns["filling_2nd_name"].HeaderText = "Вторая начинка";
            dgvSushiList.Columns["filling_2nd_name"].Width = 100;
            dgvSushiList.Columns["filling_3rd_name"].HeaderText = "Третья начинка";
            dgvSushiList.Columns["filling_3rd_name"].Width = 100;
            dgvSushiList.Columns["topping_name"].HeaderText = "Топпинг";
            dgvSushiList.Columns["topping_name"].Width = 100;
            dgvSushiList.Columns["shaker_name"].HeaderText = "Посыпка";
            dgvSushiList.Columns["shaker_name"].Width = 100;
            dgvSushiList.Columns["sauce_name"].HeaderText = "Соус";
            dgvSushiList.Columns["sauce_name"].Width = 100;

            rbID.Checked = true;

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

        private DataTable GetDataTableFromDataGridView(DataGridView dgv)
        {
            if (dgv.DataSource is DataTable dt)
            {
                return dt.Copy();
            }
            else if (dgv.DataSource is DataView dv)
            {
                return dv.ToTable();
            }
            else
            {
                throw new InvalidOperationException("Неподдерживаемый тип источника данных для DataGridView.");
            }
        }

        private bool IllegalCharactersCheck(string text)
        {
            string legal = "abcdefghijklmnopqrstuvwxyz0123456789";

            foreach (char character in text)
            {
                //MessageBox.Show(Convert.ToString(character));

                if (!legal.Contains(character))
                    return false;
            }

            return true;
        }

        private void tbSearchSushi_TextChanged(object sender, EventArgs e)
        {

            DataTable filteredTable = GetDataTableFromDataGridView(dgvSushiList);
            string searchText = tbSearchSushi.Text.ToLower();

            if (IllegalCharactersCheck(searchText))
            {

                if (string.IsNullOrEmpty(searchText))
                {
                    dgvSushiList.DataSource = filteredTable;
                    dataSource = filteredTable;
                }
                else
                {
                    string filter = string.Join(" OR ", columnsToFilter.Select(col => $"{col} LIKE '%{searchText}%'"));
                    filteredTable.DefaultView.RowFilter = filter;
                    dgvSushiList.DataSource = filteredTable.DefaultView;
                    dataSource = filteredTable;
                }
            }
            dgvSushiList.DataSource = dataSource;
        }
        private string[] allColumns = { "id", "recipe_name", "rice_name", "wrap_name", "filling_1st_name", "filling_2nd_name", "filling_3rd_name", "topping_name", "shaker_name", "sauce_name" };
        private string[] columnsToFilter;
        private void UpdateColumnsToFilter()
        {
            if (rbAll.Checked)
            {
                columnsToFilter = allColumns;
            }
            else if (rbID.Checked)
            {
                columnsToFilter = new string[] { "id" };
            }
            else if (rbName.Checked)
            {
                columnsToFilter = new string[] { "recipe_name" };
            }
            else if (rbFillings.Checked)
            {
                columnsToFilter = new string[] { "filling_1st_name", "filling_2nd_name", "filling_3rd_name" };
            }
        }
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSushi_TextChanged(null, null);
        }

        private void rbFillings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSushi_TextChanged(null, null);
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSushi_TextChanged(null, null);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSushi_TextChanged(null, null);
        }
    }
}
