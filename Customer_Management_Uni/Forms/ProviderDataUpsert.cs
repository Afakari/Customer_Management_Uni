using System;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class ProviderDataUpsert : Form
    {
        public string ProviderName => NameData.Text;
        public string ServiceType => ServiceTypeData.Text;
        public int Number => int.TryParse(NumberData.Text, out int result) ? result : 0;
        public string EmailAddress => EmailAddressData.Text;

        public ProviderDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string serviceType, int number, string emailAddress)
        {
            NameData.Text = name;
            ServiceTypeData.Text = serviceType;
            NumberData.Text = number.ToString();
            EmailAddressData.Text = emailAddress;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProviderName) || string.IsNullOrEmpty(ServiceType) || string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Number <= 0)
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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