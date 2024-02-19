using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        private const string connectionString = @"Data Source=THANHKHOI\SQLEXPRESS;Initial Catalog=PurchaseSystem;Integrated Security=True";
        private static object key = new object();
        private static volatile DataProvider instance;

        private DataProvider() { }

        public static DataProvider Instance {
            get
            {
                if (instance == null)
                    {
                    lock (key) {
                        instance = new DataProvider();
                    }
                }
                    return instance;
            }
        }

        // Execute the query --> return a DataTable.
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                string[] temp = query.Split(' ');
                List<string> listPara = temp.Where(item => item.StartsWith("@")).ToList();

                if (parameter != null)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }

            return table;
        }

        // Execute the query --> return the number of rows affected by the executed query.
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int acceptedRows = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                string[] temp = query.Split(' ');
                List<string> listPara = temp.Where(item => item.StartsWith("@")).ToList();

                for (int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listPara[i], parameter[i]);
                }
                acceptedRows = command.ExecuteNonQuery();

                connection.Close();
            }
            return acceptedRows;
        }

    }
}
