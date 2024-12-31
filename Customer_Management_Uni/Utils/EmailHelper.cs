using System;
using System.Net;
using System.Net.Mail;

namespace Customer_Management_Uni.Utils
{
    public class EmailHelper
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly bool _enableSsl;

        public EmailHelper(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword, bool enableSsl = true)
        {
            _smtpServer = smtpServer ?? throw new ArgumentNullException(nameof(smtpServer));
            _smtpPort = smtpPort;
            _smtpUsername = smtpUsername ?? throw new ArgumentNullException(nameof(smtpUsername));
            _smtpPassword = smtpPassword ?? throw new ArgumentNullException(nameof(smtpPassword));
            _enableSsl = enableSsl;
        }

        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                using (var client = new SmtpClient(_smtpServer, _smtpPort))
                {
                    client.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                    client.EnableSsl = _enableSsl;

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(_smtpUsername),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = false // Set to true if you want to send HTML emails
                    };
                    mailMessage.To.Add(to);

                    client.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception (you can replace this with your logging mechanism)
                Console.WriteLine($"Failed to send email: {ex.Message}");
                throw; // Re-throw the exception if you want the caller to handle it
            }
        }

        public void NotifyBooking(string userEmail, string roomName, DateTime start, DateTime end)
        {
            var subject = "Booking Confirmation";
            var body = $"Your booking for {roomName} is confirmed from {start:yyyy-MM-dd HH:mm} to {end:yyyy-MM-dd HH:mm}.";
            SendEmail(userEmail, subject, body);
        }
    }
}