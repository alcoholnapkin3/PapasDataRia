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
    public partial class SushiForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly bool isNewRecord;
        private readonly ComboBoxManager comboBoxManager;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";

        public SushiForm(DataGridViewRow row = null)
        {
            InitializeComponent();
            isNewRecord = (row == null);
            selectedRow = isNewRecord ? null : row;
            comboBoxManager = new ComboBoxManager(connectionString);
        }

        private void SushiForm_Load(object sender, EventArgs e)
        {
            comboBoxManager.FillComboBox(cbRice, "SushiRices", "name");
            comboBoxManager.FillComboBox(cbWrap, "SushiWraps", "name");
            comboBoxManager.FillComboBox(cbTopping, "SushiToppings", "name");
            comboBoxManager.FillComboBox(cbShaker, "SushiShakers", "name");
            comboBoxManager.FillComboBox(cbSauce, "SushiSauce", "name");

            comboBoxManager.FillComboBox(cbFilling1, "SushiFillings", "name");
            comboBoxManager.FillComboBox(cbFilling2, "SushiFillings", "name");
            comboBoxManager.FillComboBox(cbFilling3, "SushiFillings", "name");

            if (isNewRecord)
                this.Text = "Создание рецепта";
            else
            {
                this.Text = "Редактирование рецепта";
                tbID.Enabled = false;
                tbID.Text = Convert.ToString(selectedRow.Cells[0].Value);
                tbName.Text = Convert.ToString(selectedRow.Cells[1].Value);
                cbRice.Text = Convert.ToString(selectedRow.Cells[2].Value);
                cbWrap.Text = Convert.ToString(selectedRow.Cells[3].Value);
                isFlipped.Checked = Convert.ToBoolean(selectedRow.Cells[4].Value);
                cbFilling1.Text = Convert.ToString(selectedRow.Cells[5].Value);
                if (selectedRow.Cells[6].Value != DBNull.Value) cbFilling2.Text = Convert.ToString(selectedRow.Cells[6].Value);
                if (selectedRow.Cells[7].Value != DBNull.Value) cbFilling3.Text = Convert.ToString(selectedRow.Cells[7].Value);

                if (selectedRow.Cells[8].Value != DBNull.Value) cbTopping.Text = Convert.ToString(selectedRow.Cells[8].Value);
                if (selectedRow.Cells[9].Value != DBNull.Value) cbShaker.Text = Convert.ToString(selectedRow.Cells[9].Value);
                if (selectedRow.Cells[10].Value != DBNull.Value) cbSauce.Text = Convert.ToString(selectedRow.Cells[10].Value);
            }

            isFlipped_CheckedChanged(null, null);

        }

        private void SaveSushiRecipeButton_Click(object sender, EventArgs e)
        { 
            string name = String.Concat("'", tbName.Text.Replace("'", "''"), "'"); if (name == "''") name = "NULL";
            string rice = String.Concat("'", cbRice.Text.Replace("'", "''"), "'"); if (rice == "''") rice = "NULL";
            else rice = String.Concat("(SELECT id FROM SushiRices WHERE name = ", rice, ")");
            string wrap = String.Concat("'", cbWrap.Text.Replace("'", "''"), "'"); if (wrap == "''") wrap = "NULL";
            else wrap = String.Concat("(SELECT id FROM SushiWraps WHERE name = ", wrap, ")");
            string flip = Convert.ToString(Convert.ToByte(isFlipped.Checked));

            string fill1 = String.Concat("'", cbFilling1.Text.Replace("'", "''"), "'"); if (fill1 == "''") fill1 = "NULL";
            else fill1 = String.Concat("(SELECT id FROM SushiFillings WHERE name = ", fill1, ")");
            string fill2 = String.Concat("'", cbFilling2.Text.Replace("'", "''"), "'"); if (fill2 == "''") fill2 = "NULL";
            else fill2 = String.Concat("(SELECT id FROM SushiFillings WHERE name = ", fill2, ")");
            string fill3 = String.Concat("'", cbFilling3.Text.Replace("'", "''"), "'"); if (fill3 == "''") fill3 = "NULL";
            else fill3 = String.Concat("(SELECT id FROM SushiFillings WHERE name = ", fill3, ")");


            string top = String.Concat("'", cbTopping.Text.Replace("'", "''"), "'"); if (top == "''") top = "NULL";
            else top = String.Concat("(SELECT id FROM SushiToppings WHERE name = ", top, ")");
            string shaker = String.Concat("'", cbShaker.Text.Replace("'", "''"), "'"); if (shaker == "''") shaker = "NULL";
            else shaker = String.Concat("(SELECT id FROM SushiShakers WHERE name = ", shaker, ")");
            string sauce = String.Concat("'", cbSauce.Text.Replace("'", "''"), "'"); if (sauce == "''") sauce = "NULL";
            else sauce = String.Concat("(SELECT id FROM SushiSauce WHERE name = ", sauce, ")");

            string id = String.Concat("'", tbID.Text, "'"); if (id == "''") id = "NULL";

            string queryString;
            if (isNewRecord)
                queryString = String.Concat("INSERT INTO SushiRecipies values (",
                    id, ",", name, ",", rice, ",", wrap, ",", flip, ",",
                    fill1, ",", fill2, ",", fill3, ",",
                    top, ",", shaker, ",", sauce, ")");
            else
                queryString = String.Concat("UPDATE SushiRecipies SET name = ", name,
                    ", rice = ", rice, ", wrap = ", wrap, ", flipped = ", flip,
                    ", filling_1st = ", fill1, ", filling_2nd = ", fill2, ", filling_3rd = ", fill3,
                    ", topping = ", top, ", shaker = ", shaker, ", sauce = ", sauce, " where id = ", id);

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
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            string flip = Convert.ToString(Convert.ToInt32(isFlipped.Checked));

            MessageBox.Show(flip);
        }
        */
        private void isFlipped_CheckedChanged(object sender, EventArgs e)
        {
            if (isFlipped.Checked)
                flipLabel.Text = "Рисом наружу, обёрткой к начинке.";
            else
                flipLabel.Text = "Обёрткой наружу, рисом к начинке.";
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

        private void cbTopping_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbTopping.Text = null;
        }

        private void cbShaker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbShaker.Text = null;
        }

        private void cbSauce_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbSauce.Text = null;
        }

        private void cbFilling2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbFilling2.Text = null;
        }

        private void cbFilling3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbFilling3.Text = null;
        }
    }
}
