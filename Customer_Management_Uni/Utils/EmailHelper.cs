using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Customer_Management_Uni.Utils
{
    public class EmailHelper
    {
        public void SendEmail(string to, string subject, string body)
        {
            using (var client = new SmtpClient("smtp.example.com"))
            {
                client.Credentials = new NetworkCredential("your-email@example.com", "your-password");
                client.Send("your-email@example.com", to, subject, body);
            }
        }
    }
    //public void NotifyBooking(string userEmail, string roomName, DateTime start, DateTime end)
    //{
    //    var subject = "Booking Confirmation";
    //    var body = $"Your booking for {roomName} is confirmed from {start} to {end}.";
    //    _emailHelper.SendEmail(userEmail, subject, body);
    //}
}
