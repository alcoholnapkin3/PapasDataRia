using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PapasDataRia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
       
        }
        private void CustomersButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm customers = new CustomersForm();
            customers.ShowDialog();
            this.Show();
        }

        private void RecipiesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecipesForm recipes = new RecipesForm();
            recipes.ShowDialog();
            this.Show();
        }
    }
}
