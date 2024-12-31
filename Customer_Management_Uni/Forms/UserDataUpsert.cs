using System;
using System.Linq;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class UserDataUpsert : Form
    {
        public string ProviderName => NameData.Text;
        public string Number => NumberData.Text;
        public string EmailAddress => EmailAddressData.Text;

        public UserDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string number, string emailAddress)
        {
            NameData.Text = name;
            NumberData.Text = number.ToString();
            EmailAddressData.Text = emailAddress;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProviderName) || string.IsNullOrEmpty(EmailAddress))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Number.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}