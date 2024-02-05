using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private string uName;
        public Home(string UserName)
        {
            InitializeComponent();
            this.uName = UserName;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

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
            catch(Exception ex) 
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(cmbBoxStartStation.SelectedIndex == 0 || cmbBoxEndStation.SelectedIndex == 0) 
                {
                    MessageBox.Show("Please select the stations");
                    return;
                }

                // Create an object of the Home window, show and MainWindow hide
                string selectedStation = cmbBoxStartStation.SelectedIndex.ToString();

                ResultAndBooking resultAndBooking = new ResultAndBooking(uName,selectedStation);
                resultAndBooking.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
