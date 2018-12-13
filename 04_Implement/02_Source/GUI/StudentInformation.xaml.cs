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

namespace GUI
{
    /// <summary>
    /// Interaction logic for test1.xaml
    /// </summary>
    public partial class StudentInformation : Page
    {
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void btnEdit_click(object sender, RoutedEventArgs e)
        {
            phone_st_infor.IsReadOnly = false;
            email_st_infor.IsReadOnly = false;
            bob_st_infor.IsReadOnly = false;
            gender_st_infor.IsReadOnly = false;
            btnEdit.Visibility = Visibility.Collapsed;
            btnDoneOfEdit.Visibility = Visibility.Visible;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            phone_st_infor.IsReadOnly = true;
            email_st_infor.IsReadOnly = true;
            bob_st_infor.IsReadOnly = true;
            gender_st_infor.IsReadOnly = true;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnEdit.Visibility = Visibility.Visible;
        }
    }
}
