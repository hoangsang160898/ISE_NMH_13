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
    /// Interaction logic for test2.xaml
    /// </summary>
    public sealed partial class TeacherRole : Page
    {
        public TeacherRole()
        {

            InitializeComponent();
        }

        private void Window_Loaded_Role(object sender, RoutedEventArgs e)
        {
              
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            btnDoneOfEdit.Visibility = Visibility.Visible;
            minage.IsReadOnly = false;
            maxage.IsReadOnly = false;
            passscore.IsReadOnly = false;
            totalofclass.IsReadOnly = false;
            totalofclass10.IsReadOnly = false;
            totalofclass11.IsReadOnly = false;
            totalofclass12.IsReadOnly = false;
            totalofsubject.IsReadOnly = false;
            nameclasses10.IsReadOnly = false;
            nameclasses11.IsReadOnly = false;
            nameclasses12.IsReadOnly = false;
            namesubjects.IsReadOnly = false;
          
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            minage.IsReadOnly = true;
            maxage.IsReadOnly = true;
            passscore.IsReadOnly = true;
            totalofclass.IsReadOnly = true;
            totalofclass10.IsReadOnly = true;
            totalofclass11.IsReadOnly = true;
            totalofclass12.IsReadOnly = true;
            totalofsubject.IsReadOnly = true;
            nameclasses10.IsReadOnly = true;
            nameclasses11.IsReadOnly = true;
            nameclasses12.IsReadOnly = true;
            namesubjects.IsReadOnly = true;
        }
    }
}
