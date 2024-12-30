using System;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class UserDataUpsert : Form
    {
        public string ProviderName => NameData.Text;
        public int Number => int.TryParse(NumberData.Text, out int result) ? result : 0;
        public string EmailAddress => EmailAddressData.Text;

        public UserDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, int number, string emailAddress)
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

            if (Number <= 0)
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}