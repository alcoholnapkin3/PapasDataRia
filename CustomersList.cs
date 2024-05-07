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
    public partial class CustomersForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\test\PapasDataRia\PapasDatabase.mdf;Integrated Security=True";
        private readonly DataLoader dataLoader;
        public CustomersForm()
        {
            InitializeComponent();
            dataLoader = new DataLoader(connectionString);
            this.Load += CustomersForm_Load;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            dataLoader.UpdateView("RegularCustomersWithNames", "CreateRegularCustomersView.sql");
            dataLoader.LoadDataFromView("RegularCustomersWithNames", dataGridView1);
        }
    }
}
