using System;
using System.Collections.Generic;
using Customer_Management_Uni.Utils;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class Main : Form
    {
        private DatabaseManager databaseManager;
        private BookingService BookingHelper;
        public Main()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            BookingHelper = new BookingService(databaseManager);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadActiveReserves();
        }

        private void LoadActiveReserves()
        {
            try
            {
                DateTime now = DateTime.Now;
                List<Booking> bookings = BookingHelper.GetBookingsByDate(now);
                ActiveReservesView.DataSource = bookings;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }
    }
}
