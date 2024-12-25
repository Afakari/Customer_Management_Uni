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
                Provider ToInsertData = new Provider();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ToInsertData.Id = 0;
                    ToInsertData.Name = form.ProviderName;
                    ToInsertData.ServiceType = form.ServiceType;
                    ToInsertData.Number = form.Number;
                    ToInsertData.EmailAddress = form.EmailAddress;

                    ProviderHelper.Add(ToInsertData);
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
                string serviceType = selectedRow.Cells["ServiceType"].Value.ToString();
                int number = Convert.ToInt32(selectedRow.Cells["Number"].Value);
                string email = selectedRow.Cells["EmailAddress"].Value.ToString();

                using (ProviderDataUpsert form = new ProviderDataUpsert())
                {
                    form.PopulateFields(name, serviceType, number, email);
                    Provider ToUpdateData = new Provider();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ToUpdateData.Id = id;
                        ToUpdateData.Name = form.ProviderName;
                        ToUpdateData.ServiceType = form.ServiceType;
                        ToUpdateData.Number = form.Number;
                        ToUpdateData.EmailAddress = form.EmailAddress;

                        // Update data in the database (add your database logic here)
                        ProviderHelper.Update(id, ToUpdateData);
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
