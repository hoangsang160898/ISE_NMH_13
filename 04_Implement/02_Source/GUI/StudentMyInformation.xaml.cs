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
    public partial class StudentMyInformation : Page
    {
        private StudentDTO test = new StudentDTO { Name = "Leo Nguyen Student test", NameClass = "K16 Student test", Gender="Male", Email="testing@gmail.com", DateofBith="01.01.1998 test", Phone="0123456789", Id="leonguyenstudenttest"};
        public StudentMyInformation()
        {
            InitializeComponent();
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            phone_st_infor.IsReadOnly = false;
            email_st_infor.IsReadOnly = false;
            birthofday_st_infor.IsReadOnly = false;
            gender_st_infor.IsReadOnly = false;
            btnEdit.Visibility = Visibility.Collapsed;
            btnDoneOfEdit.Visibility = Visibility.Visible;
            gender_st_infor.IsEnabled = true;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            phone_st_infor.IsReadOnly = true;
            email_st_infor.IsReadOnly = true;
            birthofday_st_infor.IsReadOnly = true;
            gender_st_infor.IsReadOnly = true;
            gender_st_infor.IsEnabled = false;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnEdit.Visibility = Visibility.Visible;
        }
        private void Window_Loaded_StudentInformation(object sender, RoutedEventArgs e)
        {
            fullname_st_infor.Text = test.Name;
            id_st_infor.Text = test.Id;
            birthofday_st_infor.Text = test.DateofBith;
            phone_st_infor.Text = test.Phone;
            email_st_infor.Text = test.Email;
            if (test.Gender == "Male")
            {
                gender_st_infor.SelectedIndex = 1;
            }
            else if (test.Gender == "Female")
            {
                gender_st_infor.SelectedIndex = 2;
            }
            else
            {
                gender_st_infor.SelectedIndex = 0;
            }
        }
    }
}
