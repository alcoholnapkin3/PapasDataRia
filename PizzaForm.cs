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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace PapasDataRia
{
    public partial class PizzaForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly bool isNewRecord;
        private readonly ComboBoxManager comboBoxManager;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";

        public PizzaForm(DataGridViewRow row = null)
        {
            InitializeComponent();
            isNewRecord = (row == null);
            selectedRow = isNewRecord ? null : row;
            comboBoxManager = new ComboBoxManager(connectionString);
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            /*                        элемент упр-я  таблица      поле  */
            comboBoxManager.FillComboBox(cbCrust, "PizzaCrusts", "name");
            comboBoxManager.FillComboBox(cbCheese, "PizzaCheeses", "name");
            comboBoxManager.FillComboBox(cbSauce, "PizzaSauces", "name");
            
            comboBoxManager.FillComboBox(cbTopping1, "PizzaToppings", "name");
            comboBoxManager.FillComboBox(cbTopping2, "PizzaToppings", "name");
            comboBoxManager.FillComboBox(cbTopping3, "PizzaToppings", "name");
            comboBoxManager.FillComboBox(cbTopping4, "PizzaToppings", "name");

            comboBoxManager.FillComboBox(cbLocation1, "PizzaLocations", "name");
            comboBoxManager.FillComboBox(cbLocation2, "PizzaLocations", "name");
            comboBoxManager.FillComboBox(cbLocation3, "PizzaLocations", "name");
            comboBoxManager.FillComboBox(cbLocation4, "PizzaLocations", "name");

            if (isNewRecord)
                this.Text = "Создание рецепта";
            else
            {
                this.Text = "Редактирование рецепта";
                tbID.Enabled = false;
                tbID.Text = Convert.ToString(selectedRow.Cells[0].Value);
                tbName.Text = Convert.ToString(selectedRow.Cells[1].Value);
                cbCrust.Text = Convert.ToString(selectedRow.Cells[2].Value);
                cbSauce.Text = Convert.ToString(selectedRow.Cells[3].Value);
                cbCheese.Text = Convert.ToString(selectedRow.Cells[4].Value);
                cbTopping1.Text = Convert.ToString(selectedRow.Cells[5].Value);
                nudAmmount1.Value = Convert.ToByte(selectedRow.Cells[6].Value);
                cbLocation1.Text = Convert.ToString(selectedRow.Cells[7].Value);

                if (selectedRow.Cells[8].Value != DBNull.Value) cbTopping2.Text = Convert.ToString(selectedRow.Cells[8].Value);
                if (selectedRow.Cells[9].Value != DBNull.Value) nudAmmount2.Value = Convert.ToByte(selectedRow.Cells[9].Value);
                if (selectedRow.Cells[10].Value != DBNull.Value) cbLocation2.Text = Convert.ToString(selectedRow.Cells[10].Value);
                if (selectedRow.Cells[11].Value != DBNull.Value) cbTopping3.Text = Convert.ToString(selectedRow.Cells[11].Value);
                if (selectedRow.Cells[12].Value != DBNull.Value) nudAmmount3.Value = Convert.ToByte(selectedRow.Cells[12].Value);
                if (selectedRow.Cells[13].Value != DBNull.Value) cbLocation3.Text = Convert.ToString(selectedRow.Cells[13].Value);
                if (selectedRow.Cells[14].Value != DBNull.Value) cbTopping4.Text = Convert.ToString(selectedRow.Cells[14].Value);
                if (selectedRow.Cells[15].Value != DBNull.Value) nudAmmount4.Value = Convert.ToByte(selectedRow.Cells[15].Value);
                if (selectedRow.Cells[16].Value != DBNull.Value) cbLocation4.Text = Convert.ToString(selectedRow.Cells[16].Value);
            }
        }

        private void SavePizzaRecipeButton_Click(object sender, EventArgs e)
        {   
            string name = String.Concat("'", tbName.Text.Replace("'", "''"), "'");     if (name == "''") name = "NULL";
            string crust = String.Concat("'", cbCrust.Text.Replace("'", "''"), "'");   if (crust == "''") crust = "NULL";
            else crust = String.Concat("(SELECT id FROM PizzaCrusts WHERE name = ", crust, ")");
            string sauce = String.Concat("'", cbSauce.Text.Replace("'", "''"), "'");   if (sauce == "''") sauce = "NULL";
            else sauce = String.Concat("(SELECT id FROM PizzaSauces WHERE name = ", sauce, ")");
            string cheese = String.Concat("'", cbCheese.Text.Replace("'", "''"), "'"); if (cheese == "''") cheese = "NULL";
            else cheese = String.Concat("(SELECT id FROM PizzaCheeses WHERE name = ", cheese, ")");

            string top1 = String.Concat("'", cbTopping1.Text.Replace("'", "''"), "'"); if (top1 == "''") top1 = "NULL";
            else top1 = String.Concat("(SELECT id FROM PizzaToppings WHERE name = ", top1, ")");
            string top2 = String.Concat("'", cbTopping2.Text.Replace("'", "''"), "'"); if (top2 == "''") top2 = "NULL";
            else top2 = String.Concat("(SELECT id FROM PizzaToppings WHERE name = ", top2, ")");
            string top3 = String.Concat("'", cbTopping3.Text.Replace("'", "''"), "'"); if (top3 == "''") top3 = "NULL";
            else top3 = String.Concat("(SELECT id FROM PizzaToppings WHERE name = ", top3, ")");
            string top4 = String.Concat("'", cbTopping4.Text.Replace("'", "''"), "'"); if (top4 == "''") top4 = "NULL";
            else top4 = String.Concat("(SELECT id FROM PizzaToppings WHERE name = ", top4, ")");

            string amm1 = Convert.ToString(nudAmmount1.Value);  if (amm1 == "0") amm1 = "NULL";
            string amm2 = Convert.ToString(nudAmmount2.Value);  if (amm2 == "0") amm2 = "NULL";
            string amm3 = Convert.ToString(nudAmmount3.Value);  if (amm3 == "0") amm3 = "NULL";
            string amm4 = Convert.ToString(nudAmmount4.Value);  if (amm4 == "0") amm4 = "NULL";

            string loc1 = String.Concat("'", cbLocation1.Text.Replace("'", "''"), "'");    if (loc1 == "''") loc1 = "NULL";
            else loc1 = String.Concat("(SELECT id FROM PizzaLocations WHERE name = ", loc1, ")");
            string loc2 = String.Concat("'", cbLocation2.Text.Replace("'", "''"), "'");    if (loc2 == "''") loc2 = "NULL";
            else loc2 = String.Concat("(SELECT id FROM PizzaLocations WHERE name = ", loc2, ")");
            string loc3 = String.Concat("'", cbLocation3.Text.Replace("'", "''"), "'");    if (loc3 == "''") loc3 = "NULL";
            else loc3 = String.Concat("(SELECT id FROM PizzaLocations WHERE name = ", loc3, ")");
            string loc4 = String.Concat("'", cbLocation4.Text.Replace("'", "''"), "'");    if (loc4 == "''") loc4 = "NULL";
            else loc4 = String.Concat("(SELECT id FROM PizzaLocations WHERE name = ", loc4, ")");

            string id = String.Concat("'", tbID.Text, "'"); if (id == "''") id = "NULL";

            string queryString;
            if (isNewRecord)
                queryString = String.Concat("INSERT INTO PizzaRecipies values (",
                    id, ",", name, ",", crust, ",", sauce, ",", cheese, ",",
                    top1, ",", amm1, ",", loc1, ",",
                    top2, ",", amm2, ",", loc2, ",",
                    top3, ",", amm3, ",", loc3, ",",
                    top4, ",", amm4, ",", loc4, ")");
            else
                queryString = String.Concat("UPDATE PizzaRecipies SET name = ", name,
                    ", crust = ", crust, ", sauce = ", sauce, ", cheese = ", cheese,
                    ", topping_1st = ", top1, ", ammount_1st = ", amm1, ", location_1st = ", loc1,
                    ", topping_2nd = ", top2, ", ammount_2nd = ", amm2, ", location_2nd = ", loc2,
                    ", topping_3rd = ", top3, ", ammount_3rd = ", amm3, ", location_3rd = ", loc3,
                    ", topping_4th = ", top4, ", ammount_4th = ", amm4, ", location_4th = ", loc4, " where id = ", id);

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
                    MessageBox.Show(String.Concat(response, " строка с индексом ", id), "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка SQL!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* кнопка для debugging-а, потом удалить */
            
            MessageBox.Show(Convert.ToString(isNewRecord));


            /*
            string name = String.Concat("'", tbName.Text.Replace("'", "''"), "'"); if (name == "''") name = "NULL";
            MessageBox.Show(name);*/
            /* to-do: почему не обновляет уникальные символы как "ñ"? */
            /* Данная кнопка успешно выводит ñ... */
        }
    }
}
