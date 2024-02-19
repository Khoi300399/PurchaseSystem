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

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new DataProvider();
                    }
                }
                return instance;
            }
        }

        // Execute the query --> return a DataTable.
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters if provided
                AddParameters(command, parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }

            return table;
        }

        // Execute the query --> return the number of rows affected by the executed query.
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int acceptedRows = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters if provided
                AddParameters(command, parameters);

                acceptedRows = command.ExecuteNonQuery();

                connection.Close();
            }
            return acceptedRows;
        }

        public bool ExecuteScalar(string query, object[] parameter = null)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters if provided
                AddParameters(command, parameter);

                // Execute the query and check the result
                object scalarResult = command.ExecuteScalar();
                if (scalarResult != null && scalarResult != DBNull.Value)
                {
                    // Convert the result to boolean based on your condition
                    result = Convert.ToBoolean(scalarResult);
                }

                connection.Close();
            }
            return result;
        }

        // Helper method to add parameters to the SqlCommand
        private void AddParameters(SqlCommand command, object[] parameters)
        {
            if (parameters != null)
            {
                string[] listParameter = command.CommandText.Split(' ');
                List<string> listPara = listParameter.Where(item => item.StartsWith("@")).ToList();

                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.AddWithValue(listPara[i], parameters[i]);
                }
            }
        }
    }
}
