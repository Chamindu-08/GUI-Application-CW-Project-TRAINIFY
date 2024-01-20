using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Security.Cryptography.X509Certificates;

namespace TRAINIFY
{
    /// <summary>
    /// Interaction logic for ResultAndBooking.xaml
    /// </summary>
    public partial class ResultAndBooking : Window
    {
        private string sStation;
        public ResultAndBooking(string selectedStation)
        {
            InitializeComponent();

            this.sStation = selectedStation;

            LoadDataGridView();
            SetComboBoxValues();
        }

        public void LoadDataGridView()
        {
            string sql = "SELECT Train.Train_Name, Station.Station_Name, Station_Train.Arrival_Time " +
         "FROM Train " +
         "INNER JOIN Station_Train ON Train.Train_ID = Station_Train.Train_Id " +
         "INNER JOIN [Station] ON [Station].Station_ID = Station_Train.Station_ID " +
         "WHERE [Station].Station_Name = @sStation";

            DBConnection connectionRB = new DBConnection();

            using (SqlCommand commandRB = new SqlCommand(sql, connectionRB.GetDBConnection()))
            {
                commandRB.Parameters.AddWithValue("@sStation", sStation);

                SqlDataAdapter adapterH = new SqlDataAdapter(commandRB);

                DataTable tableH = new DataTable();

                adapterH.Fill(tableH);

                dataGridTrainDetails.ItemsSource = tableH.DefaultView;
            }
        }

        private void SetComboBoxValues()
        {
            try
            {
                string sql = "SELECT Train.Train_Name " +
                     "FROM Train " +
                     "INNER JOIN Station_Train ON Train.Train_ID = Station_Train.Train_Id " +
                     "INNER JOIN [Station] ON [Station].Station_ID = Station_Train.Station_ID " +
                     "WHERE [Station].Station_Name = @sStation";

                DBConnection connectionRB = new DBConnection();

                using (SqlCommand commandRB = new SqlCommand(sql, connectionRB.GetDBConnection()))
                {
                    commandRB.Parameters.AddWithValue("@sStation", sStation);

                    SqlDataReader reader = commandRB.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbBoxTrain.Items.Add(reader["Train_Name"].ToString());
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemHome_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                Home home1 = new Home();
                home1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                Home home1 = new Home();
                home1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemViewBooking_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                ViewBookings bookingsV = new ViewBookings();
                bookingsV.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemEditBooking_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                EditBooking bookingsE = new EditBooking();
                bookingsE.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemDeleteBooking_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                DeleteBooking bookingsD = new DeleteBooking();
                bookingsD.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemViewProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                ViewProfile profileV = new ViewProfile();
                profileV.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemEditProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                EditProfile profileE = new EditProfile();
                profileE.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookNow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //validation


                //sql quary database insert data

                MessageBox.Show("Booking Sucessful");

                // Create an object of the Home window, show and MainWindow hide
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
