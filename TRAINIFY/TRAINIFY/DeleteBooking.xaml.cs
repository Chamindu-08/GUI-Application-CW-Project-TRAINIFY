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
    /// Interaction logic for DeleteBooking.xaml
    /// </summary>
    public partial class DeleteBooking : Window
    {
        //create database connection
        DBConnection dBConnectionVB = new DBConnection();
        public DeleteBooking()
        {
            InitializeComponent();

            SetBookingIDComboBoxValues();
        }

        private void SetBookingIDComboBoxValues()
        {
            try
            {
                Login l2 = new Login();
                string userName1 = l2.GetUserName;

                string sql = "SELECT Booking.Booking_ID " +
                             "FROM Passenger INNER JOIN Booking " +
                             "ON Passenger.P_ID = Booking.P_ID " +
                             "WHERE Passenger.P_ID = @UserName";

                SqlCommand commandRB = new SqlCommand(sql, dBConnectionVB.GetDBConnection());

                SqlDataReader reader = commandRB.ExecuteReader();

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

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            // Create an object of the Home window, show and MainWindow hide
            try
            {
                if (cmbBoxBooking.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Booking");
                }

                string bookingID = cmbBoxBooking.SelectedItem.ToString();

                string sql = "DELETE FROM Booking " +
                            "WHERE Booking_ID = '" + bookingID + "'";

                SqlCommand commandRB = new SqlCommand(sql, dBConnectionVB.GetDBConnection());
                commandRB.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home home1 = new Home();
            home1.Show();
            this.Hide();
        }

        private void cmbBoxBooking_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbBoxBooking_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
