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
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
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

                MessageBox.Show("Edit profile Succesfull!");

                //database quary

                // Create an object of the login window, show and MainWindow hide
                Home home1 = new Home();
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
