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
    public partial class PizzasList : Form
    {
        public PizzasList()
        {
            InitializeComponent();
        }

        private void PizzasList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "papasDatabaseDataSet.PizzaRecipies". При необходимости она может быть перемещена или удалена.
            this.pizzaRecipiesTableAdapter.Fill(this.papasDatabaseDataSet.PizzaRecipies);

        }
    }
}
