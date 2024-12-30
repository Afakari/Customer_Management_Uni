using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class UserForm : Form
    {
        private DatabaseManager databaseManager;
        private UserService UserHelper;
        public UserForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            UserHelper = new UserService(databaseManager);
        }

        private void LoadActive()
        {
            try
            {
                DataTable Users = UserHelper.GetAll();
                DataView.DataSource = Users;
                DataView.AutoSize = true;
                DataView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadActive();
        }


        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataView.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    UserHelper.Delete(id);
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
            using (UserDataUpsert form = new UserDataUpsert())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    User ToInsertData = new User
                    {
                        Id = 0,
                        Name = form.ProviderName,
                        Number = form.Number,
                        EmailAddress = form.EmailAddress
                    };

                    UserHelper.Add(ToInsertData);
                }
            }
        }


        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataView.SelectedRows[0];

                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    string name = selectedRow.Cells["Name"].Value?.ToString();
                    int number = Convert.ToInt32(selectedRow.Cells["Number"].Value);
                    string email = selectedRow.Cells["EmailAddress"].Value?.ToString();

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Invalid data in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (UserDataUpsert form = new UserDataUpsert())
                    {
                        form.PopulateFields(name, number, email);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            User updatedUser = new User
                            {
                                Id = id,
                                Name = form.ProviderName,
                                Number = form.Number,
                                EmailAddress = form.EmailAddress
                            };

                            // Update data in the database
                            UserHelper.Update(id, updatedUser);

                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView (if needed)
                            LoadActive();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected for update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}



