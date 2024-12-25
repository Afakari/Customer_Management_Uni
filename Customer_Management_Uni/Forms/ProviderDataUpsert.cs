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
    }

}


