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
        }

        private void SaveSushiRecipeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
