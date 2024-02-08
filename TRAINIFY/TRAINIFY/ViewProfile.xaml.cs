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
    /// Interaction logic for ViewProfile.xaml
    /// </summary>
    public partial class ViewProfile : Window
    {
        private string uName;
        public ViewProfile(string uName)
        {
            InitializeComponent();
            this.uName = uName;
        }

        //display the personal details of the user
        private void getPersonalDetails()
        {
            //create database connection
            DBConnection DBConnectionVP = new DBConnection();
            try
            {
                //query to get the personal details of the user
                string sql = $"SELECT P_Name, NIC, P_Address, Contact_No, Email, P_Password FROM Passenger WHERE Email = '{uName}'";
                SqlCommand commandVP = new SqlCommand(sql, DBConnectionVP.GetDBConnection());
                SqlDataReader reader = commandVP.ExecuteReader();
                while (reader.Read())
                {
                    //display the personal details of the user
                    txtName.Text = reader["First_Name"].ToString();
                    txtLastName.Text = reader["First_Name"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtNIC.Text = reader["NIC"].ToString();
                    txtContact.Text = reader["Contact_Number"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
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
            // Create an object of the Home window, show and MainWindow hide
            Home home1 = new Home(uName);
            home1.Show();
            this.Hide();
        }
    }
}
