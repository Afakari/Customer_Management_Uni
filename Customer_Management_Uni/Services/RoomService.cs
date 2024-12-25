
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Room GetById(int id)
        {
            string query = "SELECT * FROM Rooms WHERE Id = @Id;";
            var parameters = new Dictionary<string, object> { { "@Id", id } };
            var results = _database.ExecuteQuery(query, parameters);

            if (results.Count > 0)
                return MapToRoom(results[0]);

            return null;
        }

        public List<Room> GetAll()
        {
            string query = "SELECT * FROM Rooms;";
            var results = _database.ExecuteQuery(query);

            var rooms = new List<Room>();
            foreach (var row in results)
            {
                rooms.Add(MapToRoom(row));
            }
            return rooms;
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

        private Room MapToRoom(Dictionary<string, object> row)
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
