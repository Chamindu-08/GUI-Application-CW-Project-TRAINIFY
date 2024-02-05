using System;
using System.Collections.Generic;
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
    /// Interaction logic for EditBooking.xaml
    /// </summary>
    public partial class EditBooking : Window
    {
        DBConnection connectionEB = new DBConnection();
        private string uName;
        public EditBooking(string uName)
        {
            InitializeComponent();
            this.uName = uName;
            SetBookingIDComboBoxValues();

        }

        private void SetBookingIDComboBoxValues()
        {
            try
            {
                string sql = "SELECT Booking.Booking_ID " +
                             "FROM Passenger INNER JOIN Booking " +
                             "ON Passenger.P_ID = Booking.P_ID " +
                             $"WHERE Passenger.P_ID = '{uName}'";

                SqlCommand commandRB = new SqlCommand(sql, connectionEB.GetDBConnection());
                
                SqlDataReader reader = commandRB.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbBoxBookingID.Items.Add(reader["Booking_ID"].ToString());
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(cmbBoxBookingID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Booking");
                }

                string bookingID = cmbBoxBookingID.SelectedItem.ToString();

                //get start station
                string sStationQ = "SELECT StartStation FROM Booking WHERE Booking_ID = '" + bookingID + "'";
                SqlCommand commandRBS = new SqlCommand(sStationQ, connectionEB.GetDBConnection());
                string sStation = commandRBS.ExecuteScalar()?.ToString();

                //fill the cmbBoxTrain values
                string sql = "SELECT Train.Train_Name " +
                     "FROM Train INNER JOIN Booking " +
                     "ON Train.Train_ID = Booking.Train_ID " +
                     "WHERE Booking.StartStation = '" + sStation + "'";

                SqlCommand commandRB = new SqlCommand(sql, connectionEB.GetDBConnection());

                SqlDataReader reader = commandRB.ExecuteReader();

                while (reader.Read())
                {
                    cmbBoxTrain.Items.Add(reader["Train_Name"].ToString());
                }

                reader.Close();

                //fill the cmbBoxTime values
                string sql1 = "SELECT Station_Train.Arrival_Time " +
                      "FROM Station_Train INNER JOIN Booking ON Station_Train.Train_ID = Booking.Train_ID " +
                      "WHERE Booking.StartStation = '" + sStation + "'";

                SqlCommand commandRB1 = new SqlCommand(sql1, connectionEB.GetDBConnection());

                SqlDataReader reader1 = commandRB1.ExecuteReader();

                while (reader1.Read())
                {
                    cmbBoxTime.Items.Add(reader1["Arrival_Time"].ToString());
                }

                reader1.Close();

                //sql update database
                string sql2 = "UPDATE Booking " +
                      "SET TQ1stClass = '"+ txt1CQ.Text + "', TQ2ndClass = '"+ txt2CQ.Text + "', TQ3rdClass = '"+ txt3CQ.Text +"', Train_ID = '"+ cmbBoxTrain.SelectedItem +"' " +
                      "WHERE Booking_ID = '" + bookingID + "'";

                SqlCommand commandRB2 = new SqlCommand(sql2, connectionEB.GetDBConnection());
                commandRB2.ExecuteNonQuery();

                MessageBox.Show("Booking edit Sucessful!");

                // Create an object of the Home window, show and MainWindow hide
                Home home1 = new Home(uName);
                home1.Show();
                this.Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
