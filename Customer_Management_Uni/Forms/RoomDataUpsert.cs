using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
