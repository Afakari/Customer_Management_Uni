using Customer_Management_Uni.Models;
using Customer_Management_Uni.Utils;
using System.Collections.Generic;
using System.Data;


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
            string query = "INSERT INTO Users (Name, Number , email_address) VALUES (@Name,@Number ,  @Email);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", user.Name },
            { "@Email", user.EmailAddress },
            { "@Number", user.Number },
        };
            _database.ExecuteNonQuery(query, parameters);
        }


        public DataTable GetAll()
        {
            string query = "SELECT * FROM Users;";
            var results = _database.ExecuteQuery(query);

            return results;
        }

        public void Update(int id, User user)
        {
            string query = "UPDATE Users SET Name = @Name, email_address = @Email WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", user.Name },
            { "@Email", user.EmailAddress },
            { "@Number", user.Number },
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

        private User MapToUser(DataRow row)
        {
            return new User
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                Number = row["Number"].ToString(),
                EmailAddress = row["email_address"].ToString() 
            };
        }
    }
}
