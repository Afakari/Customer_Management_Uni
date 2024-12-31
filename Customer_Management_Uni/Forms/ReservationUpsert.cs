using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;

namespace Customer_Management_Uni.Forms
{
    public partial class ReservationUpsert : Form
    {
        private readonly UserService _userService;
        private readonly ProviderService ProviderHelper;
        private readonly RoomService RoomHelper;

        public int UserId { get; set; }
        public int ProviderId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public ReservationUpsert(UserService userService, ProviderService providerService, RoomService roomService)
        {
            InitializeComponent();
            _userService = userService;
            ProviderHelper = providerService;
            RoomHelper = roomService;
        }

        private void ReservationUpsert_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadProviders();
            LoadRooms();
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            EndTimePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            StartTimePicker.Value = DateTime.Now;
            EndTimePicker.Value = DateTime.Now.AddDays(7);
        }

        private void LoadUsers()
        {
            var users = _userService.GetAll();
            UserComboBox.DataSource = users;
            UserComboBox.DisplayMember = "Name";
            UserComboBox.ValueMember = "Id";
        }

        private void LoadProviders()
        {
            var providers = ProviderHelper.GetAll();
            ProviderComboBox.DataSource = providers;
            ProviderComboBox.DisplayMember = "Name";
            ProviderComboBox.ValueMember = "Id";
        }

        private void LoadRooms()
        {
            var rooms = RoomHelper.GetAll();
            RoomComboBox.DataSource = rooms;
            RoomComboBox.DisplayMember = "Name";
            RoomComboBox.ValueMember = "Id";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(UserComboBox.SelectedValue);
            ProviderId = Convert.ToInt32(ProviderComboBox.SelectedValue);
            RoomId = Convert.ToInt32(RoomComboBox.SelectedValue);
            StartTime = StartTimePicker.Value;
            EndTime = EndTimePicker.Value;

            if (StartTime >= EndTime)
            {
                MessageBox.Show("End time must be after start time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}