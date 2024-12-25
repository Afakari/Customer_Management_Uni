using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Customer_Management_Uni.Utils
{
    public class DatabaseManager
    {
        private SQLiteConnection connection;
        private static string connectionString = @"Data Source=C:\Users\Keynoosh\source\repos\Customer_Management_Uni\Customer_Management_Uni\database.db;Version=3;Pooling=True;Max Pool Size=100;";

        public DatabaseManager()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var cmd = new SQLiteCommand(query, connection))
            {
                AddParameters(cmd, parameters);
                cmd.ExecuteNonQuery();
            }
        }



        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            var results = new List<Dictionary<string, object>>();

            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    AddParameters(cmd, parameters);
                }

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
        }



        private void AddParameters(SQLiteCommand cmd, Dictionary<string, object> parameters)
        {
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
        }


        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }

}
