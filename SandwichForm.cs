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
    public partial class SandwichForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly bool isNewRecord;
        private readonly ComboBoxManager comboBoxManager;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";

        public SandwichForm(DataGridViewRow row = null)
        {
            InitializeComponent();
            isNewRecord = (row == null);
            selectedRow = isNewRecord ? null : row;
            comboBoxManager = new ComboBoxManager(connectionString);
        }

        private void SandwichForm_Load(object sender, EventArgs e)
        {
            comboBoxManager.FillComboBox(cbMeatAndAlternative1, "SandwichMeatsAndAlternatives", "name");
            comboBoxManager.FillComboBox(cbMeatAndAlternative2, "SandwichMeatsAndAlternatives", "name");

            comboBoxManager.FillComboBox(cbBatterAndBreading1, "SandwichBattersAndBreadings", "name");
            comboBoxManager.FillComboBox(cbBatterAndBreading2, "SandwichBattersAndBreadings", "name");

            comboBoxManager.FillComboBox(cbBun, "SandwichBuns", "name");

            comboBoxManager.FillComboBox(cbToppingAndSauce1, "SandwichToppingsAndSauces", "name");
            comboBoxManager.FillComboBox(cbToppingAndSauce2, "SandwichToppingsAndSauces", "name");
            comboBoxManager.FillComboBox(cbToppingAndSauce3, "SandwichToppingsAndSauces", "name");
            comboBoxManager.FillComboBox(cbToppingAndSauce4, "SandwichToppingsAndSauces", "name");
            comboBoxManager.FillComboBox(cbToppingAndSauce5, "SandwichToppingsAndSauces", "name");
            comboBoxManager.FillComboBox(cbToppingAndSauce6, "SandwichToppingsAndSauces", "name");

            if (isNewRecord)
                this.Text = "Создание рецепта";
            else
            {
                this.Text = "Редактирование рецепта";
                tbID.Enabled = false;
                tbID.Text = Convert.ToString(selectedRow.Cells[0].Value);
                tbName.Text = Convert.ToString(selectedRow.Cells[1].Value);

                cbMeatAndAlternative1.Text = Convert.ToString(selectedRow.Cells[2].Value);
                cbBatterAndBreading1.Text = Convert.ToString(selectedRow.Cells[3].Value);
                if (selectedRow.Cells[4].Value != DBNull.Value) cbMeatAndAlternative2.Text = Convert.ToString(selectedRow.Cells[4].Value);
                if (selectedRow.Cells[5].Value != DBNull.Value) cbBatterAndBreading2.Text = Convert.ToString(selectedRow.Cells[5].Value);
                cbBun.Text = Convert.ToString(selectedRow.Cells[6].Value);

                cbToppingAndSauce1.Text = Convert.ToString(selectedRow.Cells[7].Value);
                cbToppingAndSauce2.Text = Convert.ToString(selectedRow.Cells[8].Value);
                cbToppingAndSauce3.Text = Convert.ToString(selectedRow.Cells[9].Value);
                cbToppingAndSauce4.Text = Convert.ToString(selectedRow.Cells[10].Value);
                cbToppingAndSauce5.Text = Convert.ToString(selectedRow.Cells[11].Value);
                if (selectedRow.Cells[12].Value != DBNull.Value) cbToppingAndSauce6.Text = Convert.ToString(selectedRow.Cells[12].Value);


            }
        }

        private void SaveSandwichRecipeButton_Click(object sender, EventArgs e)
        {
            string name = String.Concat("'", tbName.Text.Replace("'", "''"), "'"); if (name == "''") name = "NULL";

            string meat1 = String.Concat("'", cbMeatAndAlternative1.Text.Replace("'", "''"), "'"); if (meat1 == "''") meat1 = "NULL";
            else meat1 = String.Concat("(SELECT id FROM SandwichMeatsAndAlternatives WHERE name = ", meat1, ")");
            string batter1 = String.Concat("'", cbBatterAndBreading1.Text.Replace("'", "''"), "'"); if (batter1 == "''") batter1 = "NULL";
            else batter1 = String.Concat("(SELECT id FROM SandwichBattersAndBreadings WHERE name = ", batter1, ")");

            string meat2 = String.Concat("'", cbMeatAndAlternative2.Text.Replace("'", "''"), "'"); if (meat2 == "''") meat2 = "NULL";
            else meat2 = String.Concat("(SELECT id FROM SandwichMeatsAndAlternatives WHERE name = ", meat2, ")");
            string batter2 = String.Concat("'", cbBatterAndBreading2.Text.Replace("'", "''"), "'"); if (batter2 == "''") batter2 = "NULL";
            else batter2 = String.Concat("(SELECT id FROM SandwichBattersAndBreadings WHERE name = ", batter2, ")");

            string bun = String.Concat("'", cbBun.Text.Replace("'", "''"), "'"); if (bun == "''") bun = "NULL";
            else bun = String.Concat("(SELECT id FROM SandwichBuns WHERE name = ", bun, ")");

            string top1 = String.Concat("'", cbToppingAndSauce1.Text.Replace("'", "''"), "'"); if (top1 == "''") top1 = "NULL";
            else top1 = String.Concat("(SELECT id FROM SandwichToppingsAndSauces WHERE name = ", top1, ")");
            string top2 = String.Concat("'", cbToppingAndSauce2.Text.Replace("'", "''"), "'"); if (top2 == "''") top2 = "NULL";
            else top2 = String.Concat("(SELECT id FROM SandwichToppingsAndSauces WHERE name = ", top2, ")");
            string top3 = String.Concat("'", cbToppingAndSauce3.Text.Replace("'", "''"), "'"); if (top3 == "''") top3 = "NULL";
            else top3 = String.Concat("(SELECT id FROM SandwichToppingsAndSauces WHERE name = ", top3, ")");

            string top4 = String.Concat("'", cbToppingAndSauce4.Text.Replace("'", "''"), "'"); if (top4 == "''") top4 = "NULL";
            else top4 = String.Concat("(SELECT id FROM SandwichToppingsAndSauces WHERE name = ", top4, ")");
            string top5 = String.Concat("'", cbToppingAndSauce5.Text.Replace("'", "''"), "'"); if (top5 == "''") top5 = "NULL";
            else top5 = String.Concat("(SELECT id FROM SandwichToppingsAndSauces WHERE name = ", top5, ")");
            string top6 = String.Concat("'", cbToppingAndSauce6.Text.Replace("'", "''"), "'"); if (top6 == "''") top6 = "NULL";
            else top6 = String.Concat("(SELECT id FROM SandwichToppingsAndSauces WHERE name = ", top6, ")");

            string id = String.Concat("'", tbID.Text, "'"); if (id == "''") id = "NULL";

            string queryString;
            if (isNewRecord)
                queryString = String.Concat("INSERT INTO SandwichRecipies values (",
                    id, ",", name, ",", 
                    meat1, ",", batter1, ",", meat2, ",", batter2, ",", bun, ",",
                    top1, ",", top2, ",", top3, ",",
                    top4, ",", top5, ",", top6, ")");
            else
                queryString = String.Concat("UPDATE SandwichRecipies SET name = ", name,
                    ", meat_or_alternative = ", meat1,  ", batter_or_breading = ", batter1, 
                    ", extra_meat_or_alternative = ", meat2, ", extra_batter_or_breading = ", batter2, ", bun = ", bun,
                    ", topping_or_sauce_1st = ", top1,
                    ", topping_or_sauce_2nd = ", top2,
                    ", topping_or_sauce_3rd = ", top3,
                    ", topping_or_sauce_4th = ", top4,
                    ", topping_or_sauce_5th = ", top5,
                    ", topping_or_sauce_6th = ", top6, " where id = ", id);
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
                    MessageBox.Show(String.Concat(response, " строка с индексом ", id), "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
