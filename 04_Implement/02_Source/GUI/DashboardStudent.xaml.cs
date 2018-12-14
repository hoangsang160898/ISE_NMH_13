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
using System.Windows.Navigation;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for DashBoardStudent.xaml
    /// </summary>
    public partial class DashboardStudent : Window
    {
        private StudentDTO test = new StudentDTO { Name="Leo Nguyen test", NameClass="K16 test"};
        public DashboardStudent()
        {         
            InitializeComponent();
        }

        private void btnMini_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Content = new StudentInformation();
                    break;
                case 1:
                    GridPrincipal.Content = new StudentScore();
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            GridCursor.Margin = new Thickness(0, (100+(60 * index)), 0, 0);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Window_Loaded_TitleStudent(object sender, RoutedEventArgs e)
        {
            var student = test;
            fullname_title.Content = test.Name;
            class_title.Content = test.NameClass;
        }
    }
}
