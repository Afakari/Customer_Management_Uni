using System.Data;

namespace Customer_Management_Uni.Services
{
    using Customer_Management_Uni.Models;
    using Customer_Management_Uni.Utils;
    using System.Collections.Generic;

    public class ProviderService
    {
        private readonly DatabaseManager _database;

        public ProviderService(DatabaseManager database)
        {
            _database = database;
        }

        public void Add(Provider provider)
        {
            string query = "INSERT INTO Providers (Name, ServiceType, EmailAddress,Number) VALUES (@Name, @ServiceType,@EmailAddress ,@Number);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", provider.Name },
            { "@ServiceType", provider.ServiceType },
            { "@Number", provider.Number },
            { "@EmailAddress", provider.EmailAddress }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Providers;";
            var results = _database.ExecuteQuery(query);

 
            return results;
        }

        public void Update(int id, Provider provider)
        {
            string query = "UPDATE Providers SET Name = @Name, ServiceType = @ServiceType, Number = @Number , EmailAddress = @EmailAddress WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", provider.Name },
            { "@ServiceType", provider.ServiceType },
            { "@Number", provider.Number },
            { "@EmailAddress", provider.EmailAddress },
            { "@Id", id }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Providers WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            _database.ExecuteNonQuery(query, parameters);
        }

        private Provider MapToProvider(DataRow row)
        {
            return new Provider
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                ServiceType = row["ServiceType"].ToString(),
                Number = (int)row["Number"],
                @EmailAddress = row["EmailAddress"].ToString()
            };
        }

    }
}
