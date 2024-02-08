﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TRAINIFY
{
    /// <summary>
    /// Interaction logic for ViewBookings.xaml
    /// </summary>
    public partial class ViewBookings : Window
    {
        private string uName;
        public ViewBookings(string uName)
        {
            InitializeComponent();
            this.uName = uName;
            SetBookingIDComboBoxValues();
        }
        DBConnection dBConnectionVB = new DBConnection();
        private void SetBookingIDComboBoxValues()
        {
            try
            {
                string sql = "SELECT Booking.Booking_ID " +
                    "FROM Passenger INNER JOIN Booking " +
                    "ON Passenger.P_ID = Booking.P_ID " +
                $"WHERE Passenger.Email = '{uName}'";

                SqlCommand commandRB = new SqlCommand(sql, dBConnectionVB.GetDBConnection());

                SqlDataReader reader = commandRB.ExecuteReader();
                cmbBoxBooking.Items.Clear();
                //display the values in the combo box
                while (reader.Read())
                {
                    cmbBoxBooking.Items.Add(reader["Booking_ID"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home
                Home home1 = new Home(uName);
                home1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            //insert values from the database to the labels
            try
            {
                if (cmbBoxBooking.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Booking");
                }

                string bookingID = cmbBoxBooking.SelectedItem.ToString();

                string sql = "SELECT Train.Train_Name, Booking.StartStation, Booking.TQ1stClass, Booking.TQ2ndClass, Booking.TQ3rdClass " +
                    "FROM Train " +
                    "INNER JOIN Booking ON Train.Train_ID = Booking.Train_ID " +
                    $"WHERE Booking.Booking_ID = '{bookingID}'";

                SqlCommand commandRB = new SqlCommand(sql, dBConnectionVB.GetDBConnection());
                SqlDataReader reader = commandRB.ExecuteReader();

                //display the values in the labels
                while (reader.Read())
                {
                    lblTrain.Content = reader["Train_Name"].ToString();
                    lblStation.Content = reader["StartStation"].ToString();
                    lbl1C.Content = reader["TQ1stClass"].ToString();
                    lbl2C.Content = reader["TQ2ndClass"].ToString();
                    lbl3C.Content = reader["TQ3rdClass"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
