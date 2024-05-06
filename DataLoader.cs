using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PapasDataRia
{
    public class DataLoader
    {
        private readonly string connectionString;

        public DataLoader(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void LoadDataFromView(string viewName, DataGridView dataGridView)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM {viewName}", connection);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
        }

        public void ExecuteSqlFile(string filePath)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string script = File.ReadAllText(filePath);
                using (SqlCommand command = new SqlCommand(script, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
