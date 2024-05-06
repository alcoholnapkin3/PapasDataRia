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
    public partial class SandwichesList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;
        public SandwichesList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += SandwichesList_Load;
        }

        private void SandwichesList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("SandwichRecipiesWithNames", "CreateSandwichRecipiesView.sql");
            dataLoader.LoadDataFromView("SandwichRecipiesWithNames", dataGridView1);
        }
    }
}
