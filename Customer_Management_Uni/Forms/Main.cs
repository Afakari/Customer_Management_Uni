using System;
using System.Collections.Generic;
using Customer_Management_Uni.Utils;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using System.Windows.Forms;
using System.Data;

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




        private void AddReservation_Click(object sender, EventArgs e)
        {
            var userService = new UserService(databaseManager);
            var providerService = new ProviderService(databaseManager);
            var roomService = new RoomService(databaseManager);

            using (var form = new ReservationUpsert(userService, providerService, roomService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var reservation = new Booking
                    {
                        user_id = form.UserId,
                        provider_id = form.ProviderId,
                        room_id = form.RoomId,
                        start_time = form.StartTime,
                        end_time = form.EndTime
                    };

                    if (BookingHelper.HasConflict(reservation))
                    {
                        MessageBox.Show("Conflict detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BookingHelper.AddBooking(reservation);
                        LoadActiveReserves();
                    }
                }
            }
        }


        private void UpdateReservation_Click(object sender, EventArgs e)
        {
            if (ActiveReservesView.SelectedRows.Count > 0)
            {
                var selectedRow = ActiveReservesView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                var userService = new UserService(databaseManager);
                var providerService = new ProviderService(databaseManager);
                var roomService = new RoomService(databaseManager);
                
                Booking booking = BookingHelper.GetBookingById(id);
                using (var form = new ReservationUpsert(userService, providerService, roomService))
                {
                    form.UserId = booking.user_id;
                    form.ProviderId = booking.provider_id;
                    form.RoomId = booking.room_id;
                    form.StartTime = booking.start_time;
                    form.EndTime = booking.end_time;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var reservation = new Booking
                        {
                            user_id = form.UserId,
                            provider_id = form.ProviderId,
                            room_id = form.RoomId,
                            start_time = form.StartTime,
                            end_time = form.EndTime
                        };

                        if (BookingHelper.HasConflict(reservation))
                        {
                            MessageBox.Show("Conflict detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            BookingHelper.UpdateBooking(reservation);
                            LoadActiveReserves();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No reservation selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteReservation_Click(object sender, EventArgs e)
        {
            if (ActiveReservesView.SelectedRows.Count > 0)
            {
                var selectedRow = ActiveReservesView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                BookingHelper.DeleteBooking(id);
                LoadActiveReserves();
            }
            else
            {
                MessageBox.Show("No reservation selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                DataTable bookings = BookingHelper.GetBookingsByDate(now);
                ActiveReservesView.DataSource = bookings;
                ActiveReservesView.AutoSize = true;
                ActiveReservesView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProviderForm form = new ProviderForm();
            form.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.ShowDialog();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm form = new RoomForm();
            form.ShowDialog();
        }

        // todo
        // add and craete reservations in the main.cs
        // add the emial util to reservation service
        // fix the row select thingy and catch the id in all th ehelper forms
        // for the main page 
        // we need to check by user room providers 
        // we also need to check if the provders and the users and the rooms are actually free at the time
        // for that we can make a complex join in the reservation se        rvice
        // and get some ors to check if any of those have any time conflicts
        // we also need to check for the cases that have maybe conflicting time , like 12:00 - 12:30 / 12:15 -  12:45 
    }
}
