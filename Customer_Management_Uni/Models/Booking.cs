using System;


namespace Customer_Management_Uni.Models
{
    public class Booking
    {
        public int booking_id { get; set; }
        public int user_id { get; set; }
        public int provider_id { get; set; }
        public int room_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }
}
