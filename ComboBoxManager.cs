using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PapasDataRia
{
    public class ComboBoxManager
    {
        private readonly string _connectionString;

        public ComboBoxManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void FillComboBox(ComboBox comboBox, string tableName, string columnName)
        {
            string query = $"SELECT {columnName} FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader[columnName]);
                        }
                    }
                }
            }
        }
    }
} 
