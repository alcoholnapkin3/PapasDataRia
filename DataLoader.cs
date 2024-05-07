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
        public void UpdateView(string viewName, string sqlFilePath)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверяем, существует ли представление
                using (SqlCommand checkCommand = new SqlCommand($"IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'{viewName}')) SELECT 1 ELSE SELECT 0", connection))
                {
                    int exists = (int)checkCommand.ExecuteScalar();

                    if (exists == 0)
                    {
                        // Если представление не существует, создаем его
                        using (SqlCommand createCommand = new SqlCommand(File.ReadAllText(sqlFilePath), connection))
                        {
                            createCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Если представление существует, сначала удаляем его, а затем создаем заново
                        using (SqlCommand dropCommand = new SqlCommand($"DROP VIEW {viewName}", connection))
                        {
                            dropCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand createCommand = new SqlCommand(File.ReadAllText(sqlFilePath), connection))
                        {
                            createCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
