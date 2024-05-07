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
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;
        public DonutsList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += DonutsList_Load;
        }
        private void DonutsList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("DonutRecipiesWithNames", "CreateDonutRecipiesView.sql");
            dataLoader.LoadDataFromView("DonutRecipiesWithNames", dataGridView1);
        }
    }
}
