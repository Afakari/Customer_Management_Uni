using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Customer_Management_Uni.Models;
using Customer_Management_Uni.Services;
using Customer_Management_Uni.Utils;
using Microsoft.Data.Sqlite;

namespace Customer_Management_Uni
{

    public partial class MainForm : Form
    {
        DatabaseManager dbmanager;
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        private DataSet GetBookingDataSetByDate(DateTime date)
        {

            DataSet bookingDataSet = new DataSet("BookingDataSet");

 
            BookingService bs = new BookingService(dbmanager))
            var bookings = bs.GetBookingsByDate(date);


                DataTable bookingTable = CreateBookingDataTable(bookings);

                bookingDataSet.Tables.Add(bookingTable);
            }

            return bookingDataSet;
        }
       
    }
}