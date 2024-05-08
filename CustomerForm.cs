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
        }
    }
}
