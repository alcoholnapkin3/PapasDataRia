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

        private DataTable dataSource;
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

            dataSource = GetDataTableFromDataGridView(dgvSandwichesList);
            dgvSandwichesList.AutoResizeColumnHeadersHeight();
            dgvSandwichesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

            dgvSandwichesList.Columns["id"].HeaderText = "ID";
            dgvSandwichesList.Columns["id"].Width = 50;
            dgvSandwichesList.Columns["recipe_name"].HeaderText = "Название";
            dgvSandwichesList.Columns["recipe_name"].Width = 100;
            dgvSandwichesList.Columns["meat_or_alternative_name"].HeaderText = "Мясо котлеты";
            dgvSandwichesList.Columns["meat_or_alternative_name"].Width = 100;
            dgvSandwichesList.Columns["batter_or_breading_name"].HeaderText = "Тесто котлеты";
            dgvSandwichesList.Columns["batter_or_breading_name"].Width = 100;
            dgvSandwichesList.Columns["extra_meat_or_alternative_name"].HeaderText = "Мясо второй котлеты"; // или панирока
            dgvSandwichesList.Columns["extra_meat_or_alternative_name"].Width = 100;
            dgvSandwichesList.Columns["extra_batter_or_breading_name"].HeaderText = "Тесто второй котлеты";
            dgvSandwichesList.Columns["extra_batter_or_breading_name"].Width = 100;
            dgvSandwichesList.Columns["bun_name"].HeaderText = "Булка";
            dgvSandwichesList.Columns["bun_name"].Width = 100;
            dgvSandwichesList.Columns["topping_or_sauce_1st_name"].HeaderText = "1-ый ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_1st_name"].Width = 100;
            dgvSandwichesList.Columns["topping_or_sauce_2nd_name"].HeaderText = "2-ой ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_2nd_name"].Width = 100;
            dgvSandwichesList.Columns["topping_or_sauce_3rd_name"].HeaderText = "3-ий ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_3rd_name"].Width = 100;
            dgvSandwichesList.Columns["topping_or_sauce_4th_name"].HeaderText = "4-ый ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_4th_name"].Width = 100;
            dgvSandwichesList.Columns["topping_or_sauce_5th_name"].HeaderText = "5-ый ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_5th_name"].Width = 100;
            dgvSandwichesList.Columns["topping_or_sauce_6th_name"].HeaderText = "6-ой ингредиент";
            dgvSandwichesList.Columns["topping_or_sauce_6th_name"].Width = 100;

            rbID.Checked = true;
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
                if (!legal.Contains(character))
                    return false;
            }

            return true;
        }


        private void tbSearchSandwich_TextChanged(object sender, EventArgs e)
        {
            DataTable filteredTable = GetDataTableFromDataGridView(dgvSandwichesList);
            string searchText = tbSearchSandwich.Text.ToLower();

            if (IllegalCharactersCheck(searchText))
            {

                if (string.IsNullOrEmpty(searchText))
                {
                    dgvSandwichesList.DataSource = filteredTable;
                    dataSource = filteredTable;
                }
                else
                {
                    string filter = string.Join(" OR ", columnsToFilter.Select(col => $"{col} LIKE '%{searchText}%'"));
                    filteredTable.DefaultView.RowFilter = filter;
                    dgvSandwichesList.DataSource = filteredTable.DefaultView;
                    dataSource = filteredTable;
                }
            }
            dgvSandwichesList.DataSource = dataSource;
        }

        private string[] allColumns = { "id", "recipe_name", "meat_or_alternative_name", "batter_or_breading_name", "extra_meat_or_alternative_name", "extra_batter_or_breading_name", "bun_name", "topping_or_sauce_1st_name", "topping_or_sauce_2nd_name", "topping_or_sauce_3rd_name", "topping_or_sauce_4th_name", "topping_or_sauce_5th_name", "topping_or_sauce_6th_name" };
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
                columnsToFilter = new string[] { "topping_or_sauce_1st_name", "topping_or_sauce_2nd_name", "topping_or_sauce_3rd_name", "topping_or_sauce_4th_name", "topping_or_sauce_5th_name", "topping_or_sauce_6th_name" };
            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSandwich_TextChanged(null, null);
        }

        private void rbFillings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSandwich_TextChanged(null, null);
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSandwich_TextChanged(null, null);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchSandwich_TextChanged(null, null);
        }

    }
}
