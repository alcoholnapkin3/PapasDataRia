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
        }
    }
}
