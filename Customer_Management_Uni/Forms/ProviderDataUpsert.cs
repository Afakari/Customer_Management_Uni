using System;
using System.Linq;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class ProviderDataUpsert : Form
    {
        public string ProviderName => NameData.Text;
        public string ServiceType => ServiceTypeData.Text;
        public string Number => NumberData.Text;
        public string EmailAddress => EmailAddressData.Text;

        public ProviderDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string serviceType, string number, string emailAddress)
        {
            NameData.Text = name;
            ServiceTypeData.Text = serviceType;
            NumberData.Text = number;
            EmailAddressData.Text = emailAddress;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProviderName) || string.IsNullOrEmpty(ServiceType) || string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Number.Any(char.IsLetter)){ 
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