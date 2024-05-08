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
    public partial class PizzasList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
        private readonly ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");

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

            dgvPizzasList.AutoResizeColumnHeadersHeight();
            dgvPizzasList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
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
    }
}
