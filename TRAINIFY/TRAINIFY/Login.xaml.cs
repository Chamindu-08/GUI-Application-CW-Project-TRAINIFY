using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //create database connection
        DBConnection DBConnectionLogin = new DBConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Password)) 
                {
                    string UserName = txtUserName.Text;
                    string Password = Convert.ToString(txtPassword.Password);

                    string SqlQuery1 = $"SELECT * FROM Passenger WHERE email = '{UserName}'";

                    SqlCommand SqlCammand01 = new SqlCommand(SqlQuery1, DBConnectionLogin.GetDBConnection());

                    SqlDataReader sqlDataReader1 = SqlCammand01.ExecuteReader();

                    if (sqlDataReader1.Read())
                    {
                        string storePassword = sqlDataReader1["P_Password"].ToString();

                        if(Password == storePassword)
                        {
                            // Create an object of the Home window, show and MainWindow hide
                            Home home1 = new Home();
                            home1.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Login failed. Incorrect password. Pleace try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Incorrect User name. Pleace try again.");
                    }

                    sqlDataReader1.Close();

                }
                else
                {
                    MessageBox.Show("Login failed. Pleace enter user name and password.");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
