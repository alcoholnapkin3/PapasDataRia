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
    public partial class RecipesForm : Form
    {
        public RecipesForm()
        {
            InitializeComponent();
        }

        private void PizzaButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PizzasList pizzasList = new PizzasList();
            pizzasList.ShowDialog();
            this.Show();
        }

        private void SushiButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SushiList sushiList = new SushiList();
            sushiList.ShowDialog();
            this.Show();
        }

        private void DonutsButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DonutsList donutsList = new DonutsList();
            donutsList.ShowDialog();
            this.Show();
        }

        private void SandwichButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SandwichesList sandwichesList = new SandwichesList();
            sandwichesList.ShowDialog();
            this.Show();
        }

        private void pbCloseRecipies_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimazeRecipies_Click(object sender, EventArgs e)
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
