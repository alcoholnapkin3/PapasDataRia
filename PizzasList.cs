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
using TheArtOfDevHtmlRenderer.Adapters;

namespace PapasDataRia
{
    public partial class PizzasList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
        private readonly ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");

        private DataTable dataSource;

        public PizzasList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += PizzasList_Load;

            // Добавление пунктов в контекстное меню
            contextMenuStrip.Items.AddRange(new[] { editMenuItem, deleteMenuItem });

            // Обработчики событий для пунктов меню
            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            // Привязка контекстного меню к DataGridView
            dgvPizzasList.ContextMenuStrip = contextMenuStrip;
        }
        private void PizzasList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("PizzaRecipiesWithNames", "CreatePizzaRecipiesView.sql");
            dataLoader.LoadDataFromView("PizzaRecipiesWithNames", dgvPizzasList);

            dataSource = GetDataTableFromDataGridView(dgvPizzasList);

            dgvPizzasList.AutoResizeColumnHeadersHeight();
            dgvPizzasList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

            dgvPizzasList.Columns["id"].HeaderText = "ID";
            dgvPizzasList.Columns["name"].HeaderText = "Название";
            dgvPizzasList.Columns["crust"].HeaderText = "Бортики";
            dgvPizzasList.Columns["sauce"].HeaderText = "Соус";
            dgvPizzasList.Columns["cheese"].HeaderText = "Сыр";

            dgvPizzasList.Columns["topping_1st"].HeaderText = "Первая начинка";
            dgvPizzasList.Columns["ammount_1st"].HeaderText = "Количество первой начинки";
            dgvPizzasList.Columns["location_1st"].HeaderText = "Положение первой начинки";

            dgvPizzasList.Columns["topping_2nd"].HeaderText = "Вторая начинка";
            dgvPizzasList.Columns["ammount_2nd"].HeaderText = "Количество второй начинки";
            dgvPizzasList.Columns["location_2nd"].HeaderText = "Положение второй начинки";

            dgvPizzasList.Columns["topping_3rd"].HeaderText = "Третья начинка";
            dgvPizzasList.Columns["ammount_3rd"].HeaderText = "Количество третьей начинки";
            dgvPizzasList.Columns["location_3rd"].HeaderText = "Положение третьей начинки";

            dgvPizzasList.Columns["topping_4th"].HeaderText = "Четвёртая начинка";
            dgvPizzasList.Columns["ammount_4th"].HeaderText = "Количество четвёртой начинки";
            dgvPizzasList.Columns["location_4th"].HeaderText = "Положение четвёртой начинки";
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            // Получение выбранной строки
            int selectedRowIndex = dgvPizzasList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPizzasList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow))
            {
                // Открытие формы для редактирования записи
                PizzaForm pizzaForm = new PizzaForm(selectedRow);

                /* $$$$$$$$$$$$ - Как это вызвать?
                if (pizzaForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("DIALOG RESULT SAID OK");

                    // Обновление записи в базе данных
                    // UpdateRecordInDatabase(editForm.UpdatedRecord);

                    // Обновление записи в DataGridView
                    // dataGridView1.Rows[selectedRowIndex] = pizzaForm.UpdatedRecord;
                }
                */

                pizzaForm.ShowDialog();
                PizzasList_Load(null, null);
            }
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            // Получение выбранной строки
            int selectedRowIndex = dgvPizzasList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPizzasList.Rows[selectedRowIndex];

            // Подтверждение удаления
            if (!(selectedRow.IsNewRow) && MessageBox.Show($"Вы уверены, что хотите удалить запись '{selectedRow.Cells[0].Value}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string queryString = String.Concat("DELETE FROM PizzaRecipies WHERE id = '", selectedRow.Cells[0].Value, "'");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    try
                    {
                        Convert.ToString(command.ExecuteNonQuery());
                        //MessageBox.Show("Строка удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Удаление строки из DataGridView
                        dgvPizzasList.Rows.RemoveAt(selectedRowIndex);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AddPizzaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PizzaForm addPizzaForm = new PizzaForm();
            addPizzaForm.ShowDialog();
            PizzasList_Load(null, null); // чтобы отобразить свежедобавленный рецепт
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

        private void tbSearchPizza_TextChanged(object sender, EventArgs e)
        {
            DataTable filteredTable = GetDataTableFromDataGridView(dgvPizzasList);
            string searchText = tbSearchPizza.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dgvPizzasList.DataSource = filteredTable;
                dataSource = filteredTable;
            }
            else
            {
                string filter = string.Join(" OR ", columnsToFilter.Select(col => $"{col} LIKE '%{searchText}%'"));
                filteredTable.DefaultView.RowFilter = filter;
                dgvPizzasList.DataSource = filteredTable.DefaultView;
                dataSource = filteredTable;
            }
            dgvPizzasList.DataSource = dataSource;
        }
        private string[] allColumns = { "id", "name", "crust", "sauce", "cheese", "topping_1st", "location_1st", "topping_2nd", "location_2nd", "topping_3rd", "location_3rd", "topping_4th", "location_4th" };
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
                columnsToFilter = new string[] { "name" };
            }
            else if (rbToppings.Checked)
            {
                columnsToFilter = new string[] { "topping_1st", "topping_2nd", "topping_3rd", "topping_4th" };
            }
        }
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchPizza_TextChanged(null, null);
        }

        private void rbToppings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchPizza_TextChanged(null, null);
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnsToFilter();
            tbSearchPizza_TextChanged(null, null);
        }
    }
}
