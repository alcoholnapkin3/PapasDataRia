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
    public partial class CustomerForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly bool isNewRecord;
        private readonly ComboBoxManager comboBoxManager;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";

        public CustomerForm(DataGridViewRow row = null)
        {
            InitializeComponent();
            isNewRecord = (row == null);
            selectedRow = isNewRecord ? null : row;
            comboBoxManager = new ComboBoxManager(connectionString);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            comboBoxManager.FillComboBox(cbPizzaRecipe, "PizzaRecipies", "name");
            comboBoxManager.FillComboBox(cbPizzaBake, "PizzaBakes", "name");
            comboBoxManager.FillComboBox(cbPizzaCut, "PizzaCuts", "name");

            comboBoxManager.FillComboBox(cbSandwichRecipe, "SandwichRecipies", "name");
            comboBoxManager.FillComboBox(cbSlushSize, "SlushSizes", "name");
            comboBoxManager.FillComboBox(cbSlushFlavor1, "SlushFlavors", "name");
            comboBoxManager.FillComboBox(cbSlushFlavor2, "SlushFlavors", "name");

            comboBoxManager.FillComboBox(cbSushiRecipe, "SushiRecipies", "name");
            comboBoxManager.FillComboBox(cbTeaFlavor, "TeaFlavors", "name");
            comboBoxManager.FillComboBox(cbTeaBubbles, "TeaBubbles", "name");

            comboBoxManager.FillComboBox(cbDonutsRecipe, "DonutsRecipies", "name");

            if (isNewRecord)
                this.Text = "Добавление посетителя";
            else
            {
                this.Text = "Редактирование записи о посетителе";
                tbName.Enabled = false;
                tbName.Text = Convert.ToString(selectedRow.Cells[0].Value);
                if (selectedRow.Cells[1].Value != DBNull.Value) cbPizzaRecipe.Text = Convert.ToString(selectedRow.Cells[1].Value);
                if (selectedRow.Cells[2].Value != DBNull.Value) cbPizzaBake.Text = Convert.ToString(selectedRow.Cells[2].Value);
                if (selectedRow.Cells[3].Value != DBNull.Value) cbPizzaCut.Text = Convert.ToString(selectedRow.Cells[3].Value);

                if (selectedRow.Cells[4].Value != DBNull.Value) cbSushiRecipe.Text = Convert.ToString(selectedRow.Cells[4].Value);
                if (selectedRow.Cells[5].Value != DBNull.Value) cbTeaFlavor.Text = Convert.ToString(selectedRow.Cells[5].Value);
                if (selectedRow.Cells[6].Value != DBNull.Value) cbTeaBubbles.Text = Convert.ToString(selectedRow.Cells[6].Value);

                if (selectedRow.Cells[7].Value != DBNull.Value) cbDonutsRecipe.Text = Convert.ToString(selectedRow.Cells[7].Value);
                if (selectedRow.Cells[8].Value != DBNull.Value) cbSandwichRecipe.Text = Convert.ToString(selectedRow.Cells[8].Value);
                if (selectedRow.Cells[9].Value != DBNull.Value) cbSlushSize.Text = Convert.ToString(selectedRow.Cells[9].Value);
                if (selectedRow.Cells[10].Value != DBNull.Value) cbSlushFlavor1.Text = Convert.ToString(selectedRow.Cells[10].Value);
                if (selectedRow.Cells[11].Value != DBNull.Value) cbSlushFlavor2.Text = Convert.ToString(selectedRow.Cells[11].Value);
            }
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
            string name = String.Concat("'", tbName.Text.Replace("'", "''"), "'"); if (name == "''") name = "NULL";

            string pizza = String.Concat("'", cbPizzaRecipe.Text.Replace("'", "''"), "'"); if (pizza == "''") pizza = "NULL";
            else pizza = String.Concat("(SELECT id FROM PizzaRecipies WHERE name = ", pizza, ")");

            string bake = String.Concat("'", cbPizzaBake.Text.Replace("'", "''"), "'"); if (bake == "''") bake = "NULL";
            else bake = String.Concat("(SELECT id FROM PizzaBakes WHERE name = ", bake, ")");
            string cut = String.Concat("'", cbPizzaCut.Text.Replace("'", "''"), "'"); if (cut == "''") cut = "NULL";
            else cut = String.Concat("(SELECT id FROM PizzaCuts WHERE name = ", cut, ")");

            string sushi = String.Concat("'", cbSushiRecipe.Text.Replace("'", "''"), "'"); if (sushi == "''") sushi = "NULL";
            else sushi = String.Concat("(SELECT id FROM SushiRecipies WHERE name = ", sushi, ")");

            string btflavor = String.Concat("'", cbTeaFlavor.Text.Replace("'", "''"), "'"); if (btflavor == "''") btflavor = "NULL";
            else btflavor = String.Concat("(SELECT id FROM TeaFlavors WHERE name = ", btflavor, ")");
            string btbubbles = String.Concat("'", cbTeaBubbles.Text.Replace("'", "''"), "'"); if (btbubbles == "''") btbubbles = "NULL";
            else btbubbles = String.Concat("(SELECT id FROM TeaBubbles WHERE name = ", btbubbles, ")");

            string donuts = String.Concat("'", cbDonutsRecipe.Text.Replace("'", "''"), "'"); if (donuts == "''") donuts = "NULL";
            else donuts = String.Concat("(SELECT id FROM DonutsRecipies WHERE name = ", donuts, ")");

            string sandwich = String.Concat("'", cbSandwichRecipe.Text.Replace("'", "''"), "'"); if (sandwich == "''") sandwich = "NULL";
            else sandwich = String.Concat("(SELECT id FROM SandwichRecipies WHERE name = ", sandwich, ")");

            string ssize = String.Concat("'", cbSlushSize.Text.Replace("'", "''"), "'"); if (ssize == "''") ssize = "NULL";
            else ssize = String.Concat("(SELECT id FROM SlushSizes WHERE name = ", ssize, ")");
            string sbflavor = String.Concat("'", cbSlushFlavor1.Text.Replace("'", "''"), "'"); if (sbflavor == "''") sbflavor = "NULL";
            else sbflavor = String.Concat("(SELECT id FROM SlushFlavors WHERE name = ", sbflavor, ")");
            string stflavor = String.Concat("'", cbSlushFlavor2.Text.Replace("'", "''"), "'"); if (stflavor == "''") stflavor = "NULL";
            else stflavor = String.Concat("(SELECT id FROM SlushFlavors WHERE name = ", stflavor, ")");

            string queryString;
            if (isNewRecord)
                queryString = String.Concat("INSERT INTO RegularCustomers values (",
                    name, ",", pizza, ",", bake, ",", cut, ",", 
                    sushi, ",", btflavor, ",", btbubbles, ",", donuts, ",", 
                    sandwich, ",", ssize, ",", sbflavor, ",", stflavor, ")");
            else
                queryString = String.Concat("UPDATE RegularCustomers SET fav_pizza_recipie = ", pizza,
                    ", fav_pizza_bake = ", bake, ", fav_pizza_cut = ", cut,
                    ", fav_sushi_recipie = ", sushi, ", fav_bubbletea_flavor = ", btflavor,
                    ", fav_bubbletea_bubbles = ", btbubbles, ", fav_donuts_recipie = ", donuts,
                    ", fav_sandwich_recipie = ", sandwich, ", fav_slush_size = ", ssize,
                    ", fav_slush_bottom_flavor = ", sbflavor, ", fav_slush_top_flavor = ", stflavor, 
                    " where customer_name = ", name);
            // now test this

            //MessageBox.Show(queryString);
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                try
                {
                    string response;
                    if (isNewRecord) response = "Добвалена";
                    else response = "Обновлена";
                    Convert.ToString(command.ExecuteNonQuery());
                    MessageBox.Show(String.Concat(response, " строка с именем ", name), "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void pbCloseMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimazeMain_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void cbPizzaRecipe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbPizzaRecipe.Text = null;
        }

        private void cbPizzaBake_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbPizzaBake.Text = null;
        }

        private void cbPizzaCut_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbPizzaCut.Text = null;
        }

        private void cbSushiRecipe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbSushiRecipe.Text = null;
        }

        private void cbTeaFlavor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbTeaFlavor.Text = null;
        }

        private void cbTeaBubbles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbTeaBubbles.Text = null;
        }

        private void cbDonutsRecipe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbDonutsRecipe.Text = null;
        }

        private void cbSandwichRecipe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbSandwichRecipe.Text = null;
        }

        private void cbSlushSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbSlushSize.Text = null;
        }

        private void cbSlushFlavor1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbSlushFlavor1.Text = null;
        }

        private void cbSlushFlavor2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbSlushFlavor2.Text = null;
        }
    }
}
