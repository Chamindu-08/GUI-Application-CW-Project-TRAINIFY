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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        //create database connection
        DBConnection DBConnectionRegister = new DBConnection();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                //validating 
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    MessageBox.Show("Please enter First Name.");
                    return;
                }

                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("Please enter Last Name.");
                    return;
                }

                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please enter Address.");
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Please enter Email.");
                    return;
                }

                if (string.IsNullOrEmpty(txtNIC.Text))
                {
                    MessageBox.Show("Please enter NIC.");
                    return;
                }

                if (string.IsNullOrEmpty(txtContactNo.Text))
                {
                    MessageBox.Show("Please enter Contact No.");
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter Password.");
                    return;
                }

                if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please enter Confirm Password.");
                    return;
                }

                //check password are equal
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match. Please enter correctly.");
                    return;
                }

                if (checkBoxAgree.IsChecked == false)                
                {
                    MessageBox.Show("Please confirm agreement.");
                    return;
                }

                // Check the email is already registered
                if (EmailVerify(txtEmail.Text))
                {
                    MessageBox.Show("This email is already registered. Please use a different email.");
                    return;
                }

                string PID = GeneratePassengerID();

                //database quary
                /* string sqiQueryRegister = "INSERT INTO Passenger(P_ID, P_Name, NIC, P_Address, Contact_No, Email, P_Password)" +
                                           "VALUES" +
                                           $"('{PID}','"+txtFirstName.Text+"','"+txtNIC.Text+"','"+txtAddress.Text+"','"+txtContactNo.Text+"','"+txtEmail.Text+"','"+txtPassword.Text+"')";
                */

                string sqlQueryInsertData = "INSERT INTO Passenger (P_ID, P_Name, NIC, P_Address, Contact_No, Email, P_Password)" +
                           "VALUES (@PID, @FirstName, @NIC, @Address, @ContactNo, @Email, @Password)";

                SqlCommand sqlCommand = new SqlCommand(sqlQueryInsertData, DBConnectionRegister.GetDBConnection());
                
                sqlCommand.Parameters.AddWithValue("@PID", PID);
                sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@NIC", txtNIC.Text);
                sqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text);

                sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show("Registation Succesfull!");

                // Create an object of the login window, show and MainWindow hide
                Login login2 = new Login();
                login2.Show();
                this.Hide();

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        public string GeneratePassengerID()
        {
            try
            {
                string sqlQuery2 = "SELECT MAX(P_ID) FROM Passenger";

                SqlCommand sqlCommand01 = new SqlCommand(sqlQuery2, DBConnectionRegister.GetDBConnection());

                object result = sqlCommand01.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    string lastPID = result.ToString();
                    int maxID = Convert.ToInt32(lastPID.Substring(1));
                    string newID = $"P{maxID + 1:D3}";
                    return newID;
                }
                else
                {
                    return "P001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "P001";
            }
            
        }

        private bool EmailVerify(string email)
        {
            try
            {
                string userEmail = txtEmail.Text;
                string sqlQuery3 = $"SELECT COUNT(P_ID) FROM Passenger WHERE Email = '{userEmail}'";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery3, DBConnectionRegister.GetDBConnection());

                int count = (int)sqlCommand.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
