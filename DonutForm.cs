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
    public partial class DonutForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly bool isNewRecord;
        private readonly ComboBoxManager comboBoxManager;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";

        public DonutForm(DataGridViewRow row = null)
        {
            InitializeComponent();
            isNewRecord = (row == null);
            selectedRow = isNewRecord ? null : row;
            comboBoxManager = new ComboBoxManager(connectionString);
        }

        private void DonutForm_Load(object sender, EventArgs e)
        {
            comboBoxManager.FillComboBox(cbDough1, "DonutDoughs", "name");
            comboBoxManager.FillComboBox(cbDough2, "DonutDoughs", "name");
            comboBoxManager.FillComboBox(cbDough3, "DonutDoughs", "name");

            comboBoxManager.FillComboBox(cbShape1, "DonutShapes", "name");
            comboBoxManager.FillComboBox(cbShape2, "DonutShapes", "name");
            comboBoxManager.FillComboBox(cbShape3, "DonutShapes", "name");

            comboBoxManager.FillComboBox(cbFilling1, "DonutFillings", "name");
            comboBoxManager.FillComboBox(cbFilling2, "DonutFillings", "name");
            comboBoxManager.FillComboBox(cbFilling3, "DonutFillings", "name");

            comboBoxManager.FillComboBox(cbIcingOrPowder1, "DonutIcingsAndPowders", "name");
            comboBoxManager.FillComboBox(cbIcingOrPowder2, "DonutIcingsAndPowders", "name");
            comboBoxManager.FillComboBox(cbIcingOrPowder3, "DonutIcingsAndPowders", "name");

            comboBoxManager.FillComboBox(cbSprinkleOrDrizzle1, "DonutSprinklesAndDrizzles", "name");
            comboBoxManager.FillComboBox(cbSprinkleOrDrizzle2, "DonutSprinklesAndDrizzles", "name");
            comboBoxManager.FillComboBox(cbSprinkleOrDrizzle3, "DonutSprinklesAndDrizzles", "name");

            comboBoxManager.FillComboBox(cbExtraSprinkleOrDrizzle1, "DonutSprinklesAndDrizzles", "name");
            comboBoxManager.FillComboBox(cbExtraSprinkleOrDrizzle2, "DonutSprinklesAndDrizzles", "name");
            comboBoxManager.FillComboBox(cbExtraSprinkleOrDrizzle3, "DonutSprinklesAndDrizzles", "name");

            if (isNewRecord)
                this.Text = "Создание рецепта";
            else
            {
                this.Text = "Редактирование рецепта";
                tbID.Enabled = false;
                tbID.Text = Convert.ToString(selectedRow.Cells[0].Value);
                tbName.Text = Convert.ToString(selectedRow.Cells[1].Value);

                cbDough1.Text = Convert.ToString(selectedRow.Cells[2].Value);
                cbDough2.Text = Convert.ToString(selectedRow.Cells[3].Value);
                cbDough3.Text = Convert.ToString(selectedRow.Cells[4].Value);

                cbShape1.Text = Convert.ToString(selectedRow.Cells[5].Value);
                cbShape2.Text = Convert.ToString(selectedRow.Cells[6].Value);
                cbShape3.Text = Convert.ToString(selectedRow.Cells[7].Value);

                if (selectedRow.Cells[8].Value != DBNull.Value) cbFilling1.Text = Convert.ToString(selectedRow.Cells[8].Value);
                if (selectedRow.Cells[9].Value != DBNull.Value) cbFilling2.Text = Convert.ToString(selectedRow.Cells[9].Value);
                if (selectedRow.Cells[10].Value != DBNull.Value) cbFilling3.Text = Convert.ToString(selectedRow.Cells[10].Value);
                
                cbIcingOrPowder1.Text = Convert.ToString(selectedRow.Cells[11].Value);
                cbIcingOrPowder2.Text = Convert.ToString(selectedRow.Cells[12].Value);
                cbIcingOrPowder3.Text = Convert.ToString(selectedRow.Cells[13].Value);

                cbSprinkleOrDrizzle1.Text = Convert.ToString(selectedRow.Cells[14].Value);
                cbSprinkleOrDrizzle2.Text = Convert.ToString(selectedRow.Cells[15].Value);
                cbSprinkleOrDrizzle3.Text = Convert.ToString(selectedRow.Cells[16].Value);

                if (selectedRow.Cells[17].Value != DBNull.Value) cbExtraSprinkleOrDrizzle1.Text = Convert.ToString(selectedRow.Cells[17].Value);
                if (selectedRow.Cells[18].Value != DBNull.Value) cbExtraSprinkleOrDrizzle2.Text = Convert.ToString(selectedRow.Cells[18].Value);
                if (selectedRow.Cells[19].Value != DBNull.Value) cbExtraSprinkleOrDrizzle3.Text = Convert.ToString(selectedRow.Cells[19].Value);
            }
        }

        private void SaveDonutRecipeButton_Click(object sender, EventArgs e)
        {
            string name = String.Concat("'", tbName.Text.Replace("'", "''"), "'"); if (name == "''") name = "NULL";

            string dough1 = String.Concat("'", cbDough1.Text.Replace("'", "''"), "'"); if (dough1 == "''") dough1 = "NULL";
            else dough1 = String.Concat("(SELECT id FROM DonutDoughs WHERE name = ", dough1, ")");
            string dough2 = String.Concat("'", cbDough2.Text.Replace("'", "''"), "'"); if (dough2 == "''") dough2 = "NULL";
            else dough2 = String.Concat("(SELECT id FROM DonutDoughs WHERE name = ", dough2, ")");
            string dough3 = String.Concat("'", cbDough2.Text.Replace("'", "''"), "'"); if (dough3 == "''") dough3 = "NULL";
            else dough3 = String.Concat("(SELECT id FROM DonutDoughs WHERE name = ", dough3, ")");

            string shape1 = String.Concat("'", cbShape1.Text.Replace("'", "''"), "'"); if (shape1 == "''") shape1 = "NULL";
            else shape1 = String.Concat("(SELECT id FROM DonutShapes WHERE name = ", shape1, ")");
            string shape2 = String.Concat("'", cbShape2.Text.Replace("'", "''"), "'"); if (shape2 == "''") shape2 = "NULL";
            else shape2 = String.Concat("(SELECT id FROM DonutShapes WHERE name = ", shape2, ")");
            string shape3 = String.Concat("'", cbShape3.Text.Replace("'", "''"), "'"); if (shape3 == "''") shape3 = "NULL";
            else shape3 = String.Concat("(SELECT id FROM DonutShapes WHERE name = ", shape3, ")");

            string fill1 = String.Concat("'", cbFilling1.Text.Replace("'", "''"), "'"); if (fill1 == "''") fill1 = "NULL";
            else fill1 = String.Concat("(SELECT id FROM DonutFillings WHERE name = ", fill1, ")");
            string fill2 = String.Concat("'", cbFilling2.Text.Replace("'", "''"), "'"); if (fill2 == "''") fill2 = "NULL";
            else fill2 = String.Concat("(SELECT id FROM DonutFillings WHERE name = ", fill2, ")");
            string fill3 = String.Concat("'", cbFilling3.Text.Replace("'", "''"), "'"); if (fill3 == "''") fill3 = "NULL";
            else fill3 = String.Concat("(SELECT id FROM DonutFillings WHERE name = ", fill3, ")");

            string iop1 = String.Concat("'", cbIcingOrPowder1.Text.Replace("'", "''"), "'"); if (iop1 == "''") iop1 = "NULL";
            else iop1 = String.Concat("(SELECT id FROM DonutIcingsAndPowders WHERE name = ",iop1, ")");
            string iop2 = String.Concat("'", cbIcingOrPowder2.Text.Replace("'", "''"), "'"); if (iop2 == "''") iop2 = "NULL";
            else iop2 = String.Concat("(SELECT id FROM DonutIcingsAndPowders WHERE name = ", iop2, ")");
            string iop3 = String.Concat("'", cbIcingOrPowder3.Text.Replace("'", "''"), "'"); if (iop3 == "''") iop3 = "NULL";
            else iop3 = String.Concat("(SELECT id FROM DonutIcingsAndPowders WHERE name = ", iop3, ")");

            string sod1 = String.Concat("'", cbSprinkleOrDrizzle1.Text.Replace("'", "''"), "'"); if (sod1 == "''") sod1 = "NULL";
            else sod1 = String.Concat("(SELECT id FROM DonutSprinklesAndDrizzles WHERE name = ", sod1, ")");
            string sod2 = String.Concat("'", cbSprinkleOrDrizzle2.Text.Replace("'", "''"), "'"); if (sod2 == "''") sod2 = "NULL";
            else sod2 = String.Concat("(SELECT id FROM DonutSprinklesAndDrizzles WHERE name = ", sod2, ")");
            string sod3 = String.Concat("'", cbSprinkleOrDrizzle3.Text.Replace("'", "''"), "'"); if (sod3 == "''") sod3 = "NULL";
            else sod3 = String.Concat("(SELECT id FROM DonutSprinklesAndDrizzles WHERE name = ", sod3, ")");

            string esod1 = String.Concat("'", cbExtraSprinkleOrDrizzle1.Text.Replace("'", "''"), "'"); if (esod1 == "''") esod1 = "NULL";
            else esod1 = String.Concat("(SELECT id FROM DonutSprinklesAndDrizzles WHERE name = ", esod1, ")");
            string esod2 = String.Concat("'", cbExtraSprinkleOrDrizzle2.Text.Replace("'", "''"), "'"); if (esod2 == "''") esod2 = "NULL";
            else esod2 = String.Concat("(SELECT id FROM DonutSprinklesAndDrizzles WHERE name = ", esod2, ")");
            string esod3 = String.Concat("'", cbExtraSprinkleOrDrizzle3.Text.Replace("'", "''"), "'"); if (esod3 == "''") esod3 = "NULL";
            else esod3 = String.Concat("(SELECT id FROM DonutSprinklesAndDrizzles WHERE name = ", esod3, ")");

            string id = String.Concat("'", tbID.Text, "'"); if (id == "''") id = "NULL";

            string queryString;
            if (isNewRecord)
                queryString = String.Concat("INSERT INTO DonutsRecipies values (",
                    id, ",", name, ",", 
                    dough1, ",", dough2, ",", dough3, ",",
                    shape1, ",", shape2, ",", shape3, ",",
                    fill1, ",", fill2, ",", fill3, ",",
                    iop1, ",", iop2, ",", iop3, ",",
                    sod1, ",", sod2, ",", sod3, ",",
                    esod1, ",", esod2, ",", esod3, ")");
            else
                queryString = String.Concat("UPDATE DonutsRecipies SET name = ", name,
                    ", dough_1st = ", dough1, ", dough_2ns = ", dough2, ", dough_3rd = ", dough3,
                    ", shape_1st = ", shape1, ", shape_2nd = ", shape2, ", shape_3rd = ", shape3,
                    ", filling_1st = ", fill1, ", filling_2nd = ", fill2, ", filling_3rd = ", fill3,
                    ", icing_or_powder_1st = ", iop1, 
                    ", icing_or_powder_2nd = ", iop2, 
                    ", icing_or_powder_3rd = ", iop3,
                    ", sprinkle_or_drizzle_1st = ", sod1, 
                    ", sprinkle_or_drizzle_2nd = ", sod2, 
                    ", sprinkle_or_drizzle_3rd = ", sod3,
                    ", extra_sprinkle_or_drizzle_1st = ", sod1, 
                    ", extra_sprinkle_or_drizzle_2nd = ", sod2, 
                    ", extra_sprinkle_or_drizzle_3rd = ", sod3, " where id = ", id);
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

        private void cbFilling1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbFilling1.Text = null;
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

        private void cbExtraSprinkleOrDrizzle1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
               cbExtraSprinkleOrDrizzle1.Text = null;
        }

        private void cbExtraSprinkleOrDrizzle2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbExtraSprinkleOrDrizzle2.Text = null;
        }

        private void cbExtraSprinkleOrDrizzle3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                cbExtraSprinkleOrDrizzle3.Text = null;
        }
    }
}
