using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace Customer_Management_Uni.Utils
{
    public class DatabaseManager
    {
        private SqliteConnection connection;

        public DatabaseManager()
        {
            connection = new SqliteConnection("Data Source=database.db;");
            connection.Open();
        }

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var cmd = new SqliteCommand (query, connection))
            {
                AddParameters(cmd, parameters);
                cmd.ExecuteNonQuery();
            }
        }



        public List<Dictionary<string, object>> ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            var results = new List<Dictionary<string, object>>();

            using (var cmd = new SqliteCommand(query, connection))
            {
                if (parameters != null)
                {
                    AddParameters(cmd, parameters);
                }

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }

            return results;
        }



        private void AddParameters(SqliteCommand cmd, Dictionary<string, object> parameters)
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
