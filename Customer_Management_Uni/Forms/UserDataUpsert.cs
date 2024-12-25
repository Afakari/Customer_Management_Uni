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
    }
}
