using System;
using System.Collections.Generic;
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
        public Home()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(cmbBoxStartStation.Text) && string.IsNullOrEmpty(cmbBoxEndStation.Text))
                {
                    MessageBox.Show("Please select the stations");
                }
                // Create an object of the Home window, show and MainWindow hide
                ResultAndBooking resultAndBooking = new ResultAndBooking();
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
