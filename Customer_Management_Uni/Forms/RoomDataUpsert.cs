using System;
using System.Windows.Forms;

namespace Customer_Management_Uni.Forms
{
    public partial class RoomDataUpsert : Form
    {
        public string Name => NameData.Text;
        public string Location => LocationData.Text;

        public RoomDataUpsert()
        {
            InitializeComponent();
        }

        public void PopulateFields(string name, string location)
        {
            NameData.Text = name;
            LocationData.Text = location;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Location))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}