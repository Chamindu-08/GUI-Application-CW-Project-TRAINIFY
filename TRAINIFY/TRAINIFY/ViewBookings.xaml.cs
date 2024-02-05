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
    /// Interaction logic for ViewBookings.xaml
    /// </summary>
    public partial class ViewBookings : Window
    {
        private string uName;
        public ViewBookings(string uName)
        {
            InitializeComponent();
            this.uName = uName;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home home1 = new Home(uName);
            home1.Show();
            this.Hide();
        }
    }
}
