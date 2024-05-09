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
    public partial class CustomersForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        private readonly ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private readonly ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
        private readonly ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");

        public CustomersForm()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += CustomersForm_Load;

            contextMenuStrip.Items.AddRange(new[] { editMenuItem, deleteMenuItem });

            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            dgvCustomersList.ContextMenuStrip = contextMenuStrip;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("RegularCustomersWithNames", "CreateRegularCustomersView.sql");
            dataLoader.LoadDataFromView("RegularCustomersWithNames", dgvCustomersList);

            dgvCustomersList.Columns["customer_name"].HeaderText = "Имя";
            dgvCustomersList.Columns["fav_pizza_recipie_name"].HeaderText = "Рецепт пиццы";
            dgvCustomersList.Columns["fav_pizza_bake_name"].HeaderText = "Прожарка пиццы";
            dgvCustomersList.Columns["fav_pizza_cut_name"].HeaderText = "Нарезка пиццы";
            dgvCustomersList.Columns["fav_sushi_recipie_name"].HeaderText = "Рецепт суши";
            dgvCustomersList.Columns["fav_bubbletea_flavor_name"].HeaderText = "Чайный аромат";
            dgvCustomersList.Columns["fav_bubbletea_bubbles_name"].HeaderText = "Чайные пузырьки";
            dgvCustomersList.Columns["fav_donuts_recipie_name"].HeaderText = "Рецепт пончиков";
            dgvCustomersList.Columns["fav_sandwich_recipie_name"].HeaderText = "Рецепт сэндвича";
            dgvCustomersList.Columns["fav_slush_size_name"].HeaderText = "Размер слаша";
            dgvCustomersList.Columns["fav_slush_bottom_flavor_name"].HeaderText = "Первый вкус слаша";
            dgvCustomersList.Columns["fav_slush_top_flavor_name"].HeaderText = "Второй вкус слаша";
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvCustomersList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCustomersList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow))
            {
                CustomerForm customerForm = new CustomerForm(selectedRow);

                customerForm.ShowDialog();
                CustomersForm_Load(null, null);
            }
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvCustomersList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCustomersList.Rows[selectedRowIndex];

            if (!(selectedRow.IsNewRow) && MessageBox.Show($"Вы уверены, что хотите удалить запись '{selectedRow.Cells[0].Value}'?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string queryString = String.Concat("DELETE FROM RegularCustomers WHERE customer_name = '", selectedRow.Cells[0].Value, "'");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    try
                    {
                        Convert.ToString(command.ExecuteNonQuery());
                        //MessageBox.Show("Строка удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCustomersList.Rows.RemoveAt(selectedRowIndex);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm addCustomerForm = new CustomerForm();
            addCustomerForm.ShowDialog();
            CustomersForm_Load(null, null);
            this.Show();
        }
    }
}
