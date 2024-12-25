using System;
using System.Collections.Generic;
using System.Linq;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Utils;

namespace Customer_Management_Uni.Services
{
    public class BookingService
    {
        private readonly DatabaseManager _dbManager;

        public BookingService(DatabaseManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void AddBooking(Booking booking)
        {
            string query = @"INSERT INTO bookings (booking_id, user_id, provider_id, room_id, start_time, end_time) 
                             VALUES (@BookingID, @UserID, @ProviderID, @RoomID, @StartTime, @EndTime)";

            var parameters = new Dictionary<string, object>
            {
                { "@BookingID", booking.booking_id },
                { "@UserID", booking.user_id },
                { "@ProviderID", booking.provider_id },
                { "@RoomID", booking.room_id },
                { "@StartTime", booking.start_time },
                { "@EndTime", booking.end_time }
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }

        public List<Booking> GetAllBookings()
        {
            string query = "SELECT * FROM bookings";

            var results = _dbManager.ExecuteQuery(query);
            var bookings = new List<Booking>();

            foreach (var row in results)
            {
                bookings.Add(MapToBooking(row));
            }

            return bookings;
        }


        public Booking GetBookingById(int bookingId)
        {
            string query = "SELECT * FROM bookings WHERE booking_id = @BookingID";

            var parameters = new Dictionary<string, object>
            {
                { "@BookingID", bookingId }
            };

            var result = _dbManager.ExecuteQuery(query, parameters);

            if (result.Count == 0) return null;
            return MapToBooking(result.First());
        }

        public List<Booking> GetBookingsByDate(DateTime? startDate = null, DateTime? endDate = null)
        {
            if (!startDate.HasValue)
                startDate = DateTime.MinValue;
            if (!endDate.HasValue)
                endDate = DateTime.MaxValue;

            string query = @"
                        SELECT * 
                        FROM bookings 
                        WHERE (start_time >= @StartDate AND start_time <= @EndDate)
                           OR (end_time >= @StartDate AND end_time <= @EndDate)";

                            var parameters = new Dictionary<string, object>
                    {
                        { "@StartDate", startDate },
                        { "@EndDate", endDate }
                    };

            var result = _dbManager.ExecuteQuery(query, parameters);

            var bookings = new List<Booking>();
            foreach (var row in result)
            {
                bookings.Add(MapToBooking(row));
            }

            return bookings;
        }

        public Booking GetBookingByUserName(string userName)
        {
            string query = @"
        SELECT 
            bookings.booking_id, 
            bookings.user_id, 
            bookings.provider_id, 
            bookings.room_id, 
            bookings.start_time, 
            bookings.end_time 
        FROM bookings 
        INNER JOIN users ON bookings.user_id = users.id
        WHERE users.name = @UserName";

        var parameters = new Dictionary<string, object>
        {
            { "@UserName", userName }
        };

            var result = _dbManager.ExecuteQuery(query, parameters);

            if (result.Count == 0) return null; // No booking found
            return MapToBooking(result.First());
        }

        public void UpdateBooking(Booking booking)
        {
            string query = @"UPDATE bookings 
                             SET user_id = @UserID, provider_id = @ProviderID, room_id = @RoomID, 
                                 start_time = @StartTime, end_time = @EndTime 
                             WHERE booking_id = @BookingID";

            var parameters = new Dictionary<string, object>
            {
                { "@BookingID", booking.booking_id },
                { "@UserID", booking.user_id },
                { "@ProviderID", booking.provider_id },
                { "@RoomID", booking.room_id },
                { "@StartTime", booking.start_time },
                { "@EndTime", booking.end_time }
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }


        public void DeleteBooking(int bookingId)
        {
            string query = "DELETE FROM bookings WHERE booking_id = @BookingID";

            var parameters = new Dictionary<string, object>
            {
                { "@BookingID", bookingId }
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }

        public bool HasConflict(Booking newBooking)
        {
            string query = @"SELECT * FROM bookings 
                             WHERE (room_id = @RoomID or provider_id = @ProviderID ) AND 
                                   ((@NewStartTime BETWEEN start_time AND end_time) OR 
                                    (@NewEndTime BETWEEN start_time AND end_time) OR 
                                    (start_time BETWEEN @NewStartTime AND @NewEndTime) OR 
                                    (end_time BETWEEN @NewStartTime AND @NewEndTime))";

            var parameters = new Dictionary<string, object>
            {
                { "@RoomID", newBooking.room_id },
                { "@ProviderID", newBooking.provider_id },
                { "@NewStartTime", newBooking.start_time },
                { "@NewEndTime", newBooking.end_time }
            };

            var result = _dbManager.ExecuteQuery(query, parameters);
            return result.Count > 0; 
        }


        private Booking MapToBooking(Dictionary<string, object> row)
        {
            return new Booking
            {
                booking_id = Convert.ToInt32(row["booking_id"]),
                user_id = Convert.ToInt32(row["user_id"]),
                provider_id = Convert.ToInt32(row["provider_id"]),
                room_id = Convert.ToInt32(row["room_id"]),
                start_time = Convert.ToDateTime(row["start_time"]),
                end_time = Convert.ToDateTime(row["end_time"])
            };
        }
    }
}
