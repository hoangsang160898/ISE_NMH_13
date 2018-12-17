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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for test1.xaml
    /// </summary>
    public partial class AdminMyInformation : Page
    {
        private AdminDTO test = new AdminDTO { Name = "Leo Nguyen Admin test", Gender = "Male", Email = "testing@gmail.com", DateofBith = "01.01.1998 test", Phone = "0123456789", Id = "leonguyenadmintest" };
        public AdminMyInformation()
        {
            InitializeComponent();
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            phone_ad_infor.IsReadOnly = false;
            email_ad_infor.IsReadOnly = false;
            birthofday_ad_infor.IsReadOnly = false;
            gender_ad_infor.IsEnabled = true;
            btnEdit.Visibility = Visibility.Collapsed;
            btnDoneOfEdit.Visibility = Visibility.Visible;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            phone_ad_infor.IsReadOnly = true;
            email_ad_infor.IsReadOnly = true;
            birthofday_ad_infor.IsReadOnly = true;
            gender_ad_infor.IsReadOnly = true;
            gender_ad_infor.IsEnabled = false;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnEdit.Visibility = Visibility.Visible;
        }
        private void Window_Loaded_AdminInformation(object sender, RoutedEventArgs e)
        {
            fullname_ad_infor.Text = test.Name;
            id_ad_infor.Text = test.Id;
            birthofday_ad_infor.Text = test.DateofBith;
            phone_ad_infor.Text = test.Phone;
            email_ad_infor.Text = test.Email;
            if (test.Gender == "Male")
            {
                gender_ad_infor.SelectedIndex = 1;
            }
            else if (test.Gender == "Female")
            {
                gender_ad_infor.SelectedIndex = 2;
            }
            else
            {
                gender_ad_infor.SelectedIndex = 0;
            }
        }
    }
}
