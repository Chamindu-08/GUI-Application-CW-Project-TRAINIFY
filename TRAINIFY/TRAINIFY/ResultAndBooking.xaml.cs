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
        DBConnection connectionRB = new DBConnection();
        private string uName;
        private string sStation;
        public ResultAndBooking(string userName,string selectedStation)
        {
            InitializeComponent();

            this.uName = userName;
            this.sStation = selectedStation;

            setStation();
            LoadDataGridView();
            SetComboBoxTrainValues();
            SetComboBoxTimeValues();
        }

        public void setStation() 
        { 
            if(sStation == "1") 
            {
                sStation = "Galle";
            }
            else if(sStation == "2") 
            {
                sStation = "Matara";
            }
            else if(sStation == "3") 
            {
                sStation = "Colombo";
            }
            else if(sStation == "4") 
            {
                sStation = "Kandy";
            }
            else if(sStation == "5") 
            {
                sStation = "Jaffna";
            }
        }

        public void LoadDataGridView()
        {
            string sql = "SELECT Train.Train_Name, Station.Station_Name, Station_Train.Arrival_Time " +
         "FROM Train " +
         "INNER JOIN Station_Train ON Train.Train_ID = Station_Train.Train_Id " +
         "INNER JOIN [Station] ON [Station].Station_ID = Station_Train.Station_ID " +
         $"WHERE [Station].Station_Name = '{sStation}'";

            SqlCommand commandRB = new SqlCommand(sql, connectionRB.GetDBConnection());

            SqlDataAdapter adapterH = new SqlDataAdapter(commandRB);

            DataTable tableH = new DataTable();

            adapterH.Fill(tableH);

            dataGridTrainDetails.ItemsSource = tableH.DefaultView;
        }

        private void SetComboBoxTrainValues()
        {
            try
            {
                string sql = "SELECT Train.Train_Name " +
                     "FROM Train " +
                     "INNER JOIN Station_Train ON Train.Train_ID = Station_Train.Train_Id " +
                     "INNER JOIN Station ON Station.Station_ID = Station_Train.Station_ID " +
                     $"WHERE Station.Station_Name = '{sStation}'";

                SqlCommand commandRB = new SqlCommand(sql, connectionRB.GetDBConnection());

                SqlDataReader reader = commandRB.ExecuteReader();
                cmbBoxTrain.Items.Clear();

                while (reader.Read())
                {
                    cmbBoxTrain.Items.Add(reader["Train_Name"].ToString());
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetComboBoxTimeValues()
        {
            try
            {
                string sql = "SELECT Train.Arrival_Time " +
                    "FROM Train " +
                    "INNER JOIN Station_Train ON Train.Train_ID = Station_Train.Train_Id " +
                    "INNER JOIN Station ON Station.Station_ID = Station_Train.Station_ID " +
                    $"WHERE Station.Station_Name = '{sStation}'";

                SqlCommand commandRB1 = new SqlCommand(sql, connectionRB.GetDBConnection());

                SqlDataReader reader = commandRB1.ExecuteReader();
                cmbBoxTrain.Items.Clear();

                while (reader.Read())
                {
                    cmbBoxTrain.Items.Add(reader["Arrival_Time"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemHome_Click(object sender, RoutedEventArgs e)
        {
            try
            {
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

        private void menuItemSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
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

        private void menuItemViewBooking_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                ViewBookings bookingsV = new ViewBookings(uName);
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
                EditBooking bookingsE = new EditBooking(uName);
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
                DeleteBooking bookingsD = new DeleteBooking(uName);
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
                ViewProfile profileV = new ViewProfile(uName);
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
                EditProfile profileE = new EditProfile(uName);
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
                if(cmbBoxTrain.SelectedItem == null) 
                {
                    MessageBox.Show("Select Train");
                }

                if(cmbBoxTime.SelectedItem == null)
                {
                    MessageBox.Show("Select Time");
                }

                if(CheckBox1Class.IsChecked == true && string.IsNullOrEmpty(txt1Class.Text)) 
                {
                    MessageBox.Show("Select Time");
                }

                if (CheckBox1Class.IsChecked == true && string.IsNullOrEmpty(txt1Class.Text))
                {
                    MessageBox.Show("Select Time");
                }

                if (CheckBox1Class.IsChecked == true && string.IsNullOrEmpty(txt1Class.Text))
                {
                    MessageBox.Show("Select Time");
                }

                string bookingId = GeneratePassengerID();

                string pID = "SELECT P_ID FROM Passenger " +
                    $"WHERE Email='{uName}'";
                SqlCommand commandRB = new SqlCommand(pID, connectionRB.GetDBConnection());
                object result = commandRB.ExecuteScalar();
                string pId = result.ToString();

                string train = cmbBoxTrain.SelectedItem.ToString();

                string tID = "SELECT Train_ID FROM Train " +
                    $"WHERE Train_Name='{train}'";
                SqlCommand commandRB1 = new SqlCommand(pID, connectionRB.GetDBConnection());
                object result1 = commandRB1.ExecuteScalar();
                string trainId = result.ToString();

                //sql quary database insert data
                string sql = "INSERT INTO Booking(Booking_ID, StartStation, TQ1stClass, TQ2ndClass, TQ3rdClass , Booking_Date, P_ID, Train_ID) " +
                    "VALUES " +
                    $"('{bookingId}','{sStation}','"+ txt1Class.Text +"','"+ txt2Class.Text +"','"+ txt3Class.Text + "',GETDATE(),'{pId}','{trainId}')";

                SqlCommand commandRB2 = new SqlCommand(sql, connectionRB.GetDBConnection());
                commandRB2.ExecuteNonQuery();

                MessageBox.Show("Booking Sucessful");

                // Create an object of the Home window, show and MainWindow hide
                Home home = new Home(uName);
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //genarate bookingID
        public string GeneratePassengerID()
        {
            try
            {
                string sqlQuery2 = "SELECT MAX(Booking_ID) FROM Booking";

                SqlCommand sqlCommand01 = new SqlCommand(sqlQuery2, connectionRB.GetDBConnection());

                object result = sqlCommand01.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    string lastPID = result.ToString();
                    int maxID = Convert.ToInt32(lastPID.Substring(1));
                    string newID = $"B{maxID + 1:D3}";
                    return newID;
                }
                else
                {
                    return "B001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "P001";
            }

        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an object of the Home window, show and MainWindow hide
                Home home = new Home(uName);
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
