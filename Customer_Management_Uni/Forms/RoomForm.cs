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
            RoomHelper = new RoomService(databaseManager);
        }

        private void RoomForm_Load(object sender, EventArgs e)
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
                MessageBox.Show($"Error loading rooms: {ex.Message}");
            }


        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
 
                    foreach (DataGridViewRow row in DataView.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        RoomHelper.Delete(id);
                    }
                    MessageBox.Show("Selected rows deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadActive();
                }
            }
            else
            {

                MessageBox.Show("No rows selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Room newRoom = new Room
                    {
                        Id = 0, 
                        Name = form.Name,
                        Location = form.Location
                    };

                    RoomHelper.Add(newRoom);
                }
            }
        }


        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string name = selectedRow.Cells["Name"].Value?.ToString();
                string location = selectedRow.Cells["Location"].Value?.ToString();

                using (RoomDataUpsert form = new RoomDataUpsert())
                {
                    form.PopulateFields(name, location);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Room ToUpdateData = new Room
                        {
                            Id = id,
                            Name = form.Name,
                            Location = form.Location
                        };

                        try
                        {
                            RoomHelper.Update(id, ToUpdateData);
                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadActive();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
