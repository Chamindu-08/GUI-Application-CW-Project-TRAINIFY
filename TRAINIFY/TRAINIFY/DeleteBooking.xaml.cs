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
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            // Create an object of the Home window, show and MainWindow hide
            Home home1 = new Home();
            home1.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            //sql quary
        }

        private void cmbBoxBooking_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            

        }
    }
}
