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
    public partial class SushiList : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;
        public SushiList()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += SushiList_Load;
        }

        private void SushiList_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("SushiRecipiesWithNames", "CreateSushiRecipiesView.sql");
            dataLoader.LoadDataFromView("SushiRecipiesWithNames", dataGridView1);
        }
    }
}
