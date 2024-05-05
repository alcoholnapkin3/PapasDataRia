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
    public partial class DonutsList : Form
    {
        public DonutsList()
        {
            InitializeComponent();
        }

        private void DonutsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "papasDatabaseDataSet.DonutsRecipies". При необходимости она может быть перемещена или удалена.
            this.donutsRecipiesTableAdapter.Fill(this.papasDatabaseDataSet.DonutsRecipies);

        }
    }
}
