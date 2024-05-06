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
using System.IO;

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
            dataGridView1.ContextMenuStrip = contextMenuStrip;
        }
        private void PizzasList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("PizzaRecipiesWithNames", "CreatePizzaRecipiesView.sql");
            dataLoader.LoadDataFromView("PizzaRecipiesWithNames", dataGridView1);
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            // Получение выбранной строки
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            // Открытие формы для редактирования записи
            PizzaForm pizzaForm = new PizzaForm(selectedRow);
            if (pizzaForm.ShowDialog() == DialogResult.OK)
            {
                // Обновление записи в базе данных
                // UpdateRecordInDatabase(editForm.UpdatedRecord);

                // Обновление записи в DataGridView
                // dataGridView1.Rows[selectedRowIndex] = pizzaForm.UpdatedRecord;
            }
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            // Получение выбранной строки
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            // Подтверждение удаления
            if (MessageBox.Show($"Вы уверены, что хотите удалить запись '{selectedRow.Cells[0].Value}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Удаление записи из базы данных
                // DeleteRecordFromDatabase(selectedRow);

                // Удаление строки из DataGridView
                // dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void AddPizzaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PizzaForm addPizzaForm = new PizzaForm();
            addPizzaForm.ShowDialog();
            this.Show();
        }
    }
}
