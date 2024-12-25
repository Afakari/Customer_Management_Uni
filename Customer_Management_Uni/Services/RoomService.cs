
using System.Data;
using System.Collections.Generic;

namespace Customer_Management_Uni.Services
{
    using Customer_Management_Uni.Models;
    using Customer_Management_Uni.Utils;
    public class RoomService
    {
        private readonly DatabaseManager _database;

        public RoomService(DatabaseManager database)
        {
            _database = database;
        }

        public void Add(Room room)
        {
            string query = "INSERT INTO Rooms (Name,  Location) VALUES (@Name,  @Location);";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", room.Name },
            { "@Location", room.Location }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Rooms;";
            var results = _database.ExecuteQuery(query);

            return results;
        }

        public void Update(int id, Room room)
        {
            string query = "UPDATE Rooms SET Name = @Name,  Location = @Location WHERE Id = @Id;";
            var parameters = new Dictionary<string, object>
        {
            { "@Name", room.Name },
            { "@Location", room.Location },
            { "@Id", id }
        };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Rooms WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            _database.ExecuteNonQuery(query, parameters);
        }

        private Room MapToRoom(DataRow row)
        {
            return new Room
            {
                Id = (int)row["Id"],
                Name = row["Name"].ToString(),
                Location = row["Location"].ToString()
            };
        }

    }
}
