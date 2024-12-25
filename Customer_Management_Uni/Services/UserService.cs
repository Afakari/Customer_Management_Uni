using Customer_Management_Uni.Models;
using Customer_Management_Uni.Utils;
using System.Collections.Generic;


namespace Customer_Management_Uni.Services
{
    public class UserService
    {
        private readonly DatabaseManager _database;

        public UserService(DatabaseManager database)
        {
            _database = database;
        }

        public void Add(User user)
        {
            string query = "INSERT INTO Users (Name, Number , Email, Password) VALUES (@Name,@Number ,  @Email, @Password);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", user.Name },
            { "@Email", user.EmailAddress },
            { "@Number", user.Number },
            { "@Password", user.Password }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public User GetById(int id)
        {
            string query = "SELECT * FROM Users WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            var results = _database.ExecuteQuery(query, parameters);

            if (results.Count > 0)
                return MapToUser(results[0]);

            return null;
        }

        public List<User> GetAll()
        {
            string query = "SELECT * FROM Users;";
            var results = _database.ExecuteQuery(query);

            var users = new List<User>();
            foreach (var row in results)
            {
                users.Add(MapToUser(row));
            }
            return users;
        }

        public void Update(int id, User user)
        {
            string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", user.Name },
            { "@Email", user.EmailAddress },
            { "@Number", user.Number },
            { "@Password", user.Password },
            { "@Id", id }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Users WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            _database.ExecuteNonQuery(query, parameters);
        }

        private User MapToUser(Dictionary<string, object> row)
        {
            return new User
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                Number = (int)row["Number"],
                EmailAddress = row["Email"].ToString(),
                Password = row["Password"].ToString()
            };
        }
    }
}
