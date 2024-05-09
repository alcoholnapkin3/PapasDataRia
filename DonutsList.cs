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
    public partial class DonutsList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
        private readonly ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");

        private DataTable dataSource;
        public DonutsList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += DonutsList_Load;

            contextMenuStrip.Items.AddRange(new[] { editMenuItem, deleteMenuItem });

            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            dgvDonutsList.ContextMenuStrip = contextMenuStrip;
        }
        private void DonutsList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("DonutRecipiesWithNames", "CreateDonutRecipiesView.sql");
            dataLoader.LoadDataFromView("DonutRecipiesWithNames", dgvDonutsList);

            dataSource = GetDataTableFromDataGridView(dgvDonutsList);
            dgvDonutsList.AutoResizeColumnHeadersHeight();
            dgvDonutsList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

            dgvDonutsList.Columns["id"].HeaderText = "ID";
            dgvDonutsList.Columns["id"].Width = 50;
            dgvDonutsList.Columns["RecipeName"].HeaderText = "Название";
            dgvDonutsList.Columns["RecipeName"].Width = 100;
            dgvDonutsList.Columns["Dough1"].HeaderText = "1-ый пончик: тесто";
            dgvDonutsList.Columns["Dough1"].Width = 100;
            dgvDonutsList.Columns["Dough2"].HeaderText = "2-ой пончик: тесто";
            dgvDonutsList.Columns["Dough2"].Width = 100;
            dgvDonutsList.Columns["Dough3"].HeaderText = "3-ий пончик: тесто";
            dgvDonutsList.Columns["Dough3"].Width = 100;
            dgvDonutsList.Columns["Shape1"].HeaderText = "1-ый пончик: форма";
            dgvDonutsList.Columns["Shape1"].Width = 100;
            dgvDonutsList.Columns["Shape2"].HeaderText = "2-ой пончик: форма";
            dgvDonutsList.Columns["Shape2"].Width = 100;
            dgvDonutsList.Columns["Shape3"].HeaderText = "3-ий пончик: форма";
            dgvDonutsList.Columns["Shape3"].Width = 100;
            dgvDonutsList.Columns["Filling1"].HeaderText = "1-ый пончик: начинка";
            dgvDonutsList.Columns["Filling1"].Width = 100;
            dgvDonutsList.Columns["Filling2"].HeaderText = "2-ой пончик: начинка";
            dgvDonutsList.Columns["Filling2"].Width = 100;
            dgvDonutsList.Columns["Filling3"].HeaderText = "3-ий пончик: начинка";
            dgvDonutsList.Columns["Filling3"].Width = 100;
            dgvDonutsList.Columns["IcingOrPowder1"].HeaderText = "1-ый пончик: глазурь";
            dgvDonutsList.Columns["IcingOrPowder1"].Width = 100;
            dgvDonutsList.Columns["IcingOrPowder2"].HeaderText = "2-ой пончик: глазурь";
            dgvDonutsList.Columns["IcingOrPowder2"].Width = 100;
            dgvDonutsList.Columns["IcingOrPowder3"].HeaderText = "3-ий пончик: глазурь";
            dgvDonutsList.Columns["IcingOrPowder3"].Width = 100;
            dgvDonutsList.Columns["SprinkleOrDrizzle1"].HeaderText = "1-ый пончик: 1-ый топпинг";
            dgvDonutsList.Columns["SprinkleOrDrizzle1"].Width = 100;
            dgvDonutsList.Columns["SprinkleOrDrizzle2"].HeaderText = "2-ой пончик: 1-ый топпинг";
            dgvDonutsList.Columns["SprinkleOrDrizzle2"].Width = 100;
            dgvDonutsList.Columns["SprinkleOrDrizzle3"].HeaderText = "3-ий пончик: 1-ый топпинг";
            dgvDonutsList.Columns["SprinkleOrDrizzle3"].Width = 100;
            dgvDonutsList.Columns["ExtraSprinkleOrDrizzle1"].HeaderText = "1-ый пончик: 2-ой топпинг";
            dgvDonutsList.Columns["ExtraSprinkleOrDrizzle1"].Width = 100;
            dgvDonutsList.Columns["ExtraSprinkleOrDrizzle2"].HeaderText = "2-ой пончик: 2-ой топпинг";
            dgvDonutsList.Columns["ExtraSprinkleOrDrizzle2"].Width = 100;
            dgvDonutsList.Columns["ExtraSprinkleOrDrizzle3"].HeaderText = "3-ий пончик: 2-ой топпинг";
            dgvDonutsList.Columns["ExtraSprinkleOrDrizzle3"].Width = 100;

            rbID.Checked = true;
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvDonutsList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvDonutsList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow))
            {
                DonutForm donutForm = new DonutForm(selectedRow);
                donutForm.ShowDialog();
                DonutsList_Load(null, null);
            }
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvDonutsList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvDonutsList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow) && MessageBox.Show($"Вы уверены, что хотите удалить запись '{selectedRow.Cells[0].Value}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string queryString = String.Concat("DELETE FROM DonutsRecipies WHERE id = '", selectedRow.Cells[0].Value, "'");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    try
                    {
                        Convert.ToString(command.ExecuteNonQuery());
                        //MessageBox.Show("Строка удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDonutsList.Rows.RemoveAt(selectedRowIndex);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void AddDonutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonutForm addDonutForm = new DonutForm();
            addDonutForm.ShowDialog();
            DonutsList_Load(null, null);
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

        
        private void tbSearchDonuts_TextChanged(object sender, EventArgs e)
        {

            DataTable filteredTable = GetDataTableFromDataGridView(dgvDonutsList);
            string searchText = tbSearchDonuts.Text.ToLower();

            if (IllegalCharactersCheck(searchText))
            {

                if (string.IsNullOrEmpty(searchText))
                {
                    dgvDonutsList.DataSource = filteredTable;
                    dataSource = filteredTable;
                }
                else
                {
                    string filter = string.Join(" OR ", columnsToFilter.Select(col => $"{col} LIKE '%{searchText}%'"));
                    filteredTable.DefaultView.RowFilter = filter;
                    dgvDonutsList.DataSource = filteredTable.DefaultView;
                    dataSource = filteredTable;
                }
            }
            dgvDonutsList.DataSource = dataSource;
        }
        
        private string[] allColumns = { "id", "RecipeName", "Dough1", "Dough2", "Dough3", "Shape1", "Shape2", "Shape3", "Filling1", "Filling2", "Filling3", "IcingOrPowder1", "IcingOrPowder2", "IcingOrPowder3", "SprinkleOrDrizzle1", "SprinkleOrDrizzle2", "SprinkleOrDrizzle3", "ExtraSprinkleOrDrizzle1", "ExtraSprinkleOrDrizzle2", "ExtraSprinkleOrDrizzle3"};
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
                columnsToFilter = new string[] { "RecipeName" };
            }
            else if (rbToppings.Checked)
            {
                columnsToFilter = new string[] { "SprinkleOrDrizzle1", "SprinkleOrDrizzle2", "SprinkleOrDrizzle3", "ExtraSprinkleOrDrizzle1", "ExtraSprinkleOrDrizzle2", "ExtraSprinkleOrDrizzle3" };
            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchDonuts_TextChanged(null, null);
        }

        private void rbToppings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchDonuts_TextChanged(null, null);
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchDonuts_TextChanged(null, null);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchDonuts_TextChanged(null, null);
        }
    }
}
