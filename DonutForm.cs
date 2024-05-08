using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void SaveDonutRecipeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
