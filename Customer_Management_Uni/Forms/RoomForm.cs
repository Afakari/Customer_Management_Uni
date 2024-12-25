using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class RoomForm : Form
    {
        private DatabaseManager databaseManager;
        private RoomService RoomHelper;
        public RoomForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            RoomService RoomHelper = new RoomService(databaseManager);
        }
        private void ProviderForm_Load(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void LoadActive()
        {
            try
            {
                DataTable rooms = RoomHelper.GetAll();
                DataView.DataSource = rooms;
                DataView.AutoSize = true;
                DataView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }


        }


        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataView.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    RoomHelper.Delete(id);
                }

                MessageBox.Show("Selected rows deleted successfully!");

                LoadActive();
            }
            else
            {
                MessageBox.Show("No rows selected.");
            }
        }

        private void RefershForm_Click(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            using (RoomDataUpsert form = new RoomDataUpsert())
            {
                Room ToInsertData = new Room();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ToInsertData.Id = 0;
                    ToInsertData.Name = form.Name;
                    ToInsertData.Location = form.Location;

                    RoomHelper.Add(ToInsertData);
                }
            }
        }


        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string name = selectedRow.Cells["Name"].Value.ToString();
                string location = selectedRow.Cells["Location"].Value.ToString();

                using (RoomDataUpsert form = new RoomDataUpsert())
                {
                    form.PopulateFields(name, location);
                    Room ToUpdateData = new Room();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ToUpdateData.Id = id;
                        ToUpdateData.Name = form.Name;
                        ToUpdateData.Location = form.Location;
                        RoomHelper.Update(id, ToUpdateData);
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.");
            }
        }

    }
}
