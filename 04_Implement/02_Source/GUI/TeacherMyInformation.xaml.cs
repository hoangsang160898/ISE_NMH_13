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
    public partial class TeacherMyInformation : Page
    {
        private TeacherDTO test = new TeacherDTO { Name = "Leo Nguyen Teacher test", Gender = "Male test", Email = "testing@gmail.com", DateofBith = "01.01.1998 test", Phone = "0123456789", Id = "leonguyeteachertest" };
        public TeacherMyInformation()
        {
            InitializeComponent();
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            phone_tc_infor.IsReadOnly = false;
            email_tc_infor.IsReadOnly = false;
            birthofday_tc_infor.IsReadOnly = false;
            gender_tc_infor.IsReadOnly = false;
            btnEdit.Visibility = Visibility.Collapsed;
            btnDoneOfEdit.Visibility = Visibility.Visible;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            phone_tc_infor.IsReadOnly = true;
            email_tc_infor.IsReadOnly = true;
            birthofday_tc_infor.IsReadOnly = true;
            gender_tc_infor.IsReadOnly = true;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnEdit.Visibility = Visibility.Visible;
        }
        private void Window_Loaded_AdminInformation(object sender, RoutedEventArgs e)
        {
            fullname_tc_infor.Text = test.Name;
            id_tc_infor.Text = test.Id;
            birthofday_tc_infor.Text = test.DateofBith;
            phone_tc_infor.Text = test.Phone;
            email_tc_infor.Text = test.Email;
            gender_tc_infor.Text = test.Gender;
        }
    }
}
