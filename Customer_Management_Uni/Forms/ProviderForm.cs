using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using System;
using Customer_Management_Uni.Models;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Customer_Management_Uni.Forms
{
    public partial class ProviderForm : Form
    {
        private DatabaseManager databaseManager;
        private ProviderService ProviderHelper;
        public ProviderForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            ProviderHelper = new ProviderService(databaseManager);
        }
        private void ProviderForm_Load(object sender, EventArgs e)
        {
            LoadActive();
        }

        private void LoadActive()
        {
            try
            {
                DataTable providers = ProviderHelper.GetAll();
                DataView.DataSource = providers;
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

                    ProviderHelper.Delete(id);
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
            using (ProviderDataUpsert form = new ProviderDataUpsert())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Provider newProvider = new Provider
                    {
                        Id = 0, 
                        Name = form.ProviderName,
                        ServiceType = form.ServiceType,
                        Number = form.Number,
                        EmailAddress = form.EmailAddress
                    };
                   

                    ProviderHelper.Add(newProvider);
                    LoadActive();
                }
            }
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count > 0)
            {
                var selectedRow = DataView.SelectedRows[0];

                try
                {
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    string name = selectedRow.Cells["Name"].Value?.ToString();
                    string serviceType = selectedRow.Cells["service_type"].Value?.ToString();
                    string number = selectedRow.Cells["Number"].Value?.ToString();
                    string email = selectedRow.Cells["email_address"].Value?.ToString();


                    using (ProviderDataUpsert form = new ProviderDataUpsert())
                    {
                        form.PopulateFields(name, serviceType, number, email);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            Provider updatedProvider = new Provider
                            {
                                Id = id,
                                Name = form.ProviderName,
                                ServiceType = form.ServiceType,
                                Number = form.Number,
                                EmailAddress = form.EmailAddress
                            };

                            ProviderHelper.Update(id, updatedProvider);

                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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