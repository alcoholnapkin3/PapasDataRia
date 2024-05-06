using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PapasDataRia
{
    public partial class PizzasList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;

        public PizzasList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += PizzasList_Load;
        }

        private void PizzasList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("PizzaRecipiesWithNames", "CreatePizzaRecipiesView.sql");
            dataLoader.LoadDataFromView("PizzaRecipiesWithNames", dataGridView1);
        }
    }
}
