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
using System.ComponentModel;

namespace GUI
{
    /// <summary>
    /// Interaction logic for DashBoardStudent.xaml
    /// </summary>
    public partial class DashboardStudent : Window, INotifyPropertyChanged
    {

        //private student_test _test;

        //public student_test test
        //{
        //    get { return _test; }
        //    set
        //    {
        //        _test = value;
        //        OnPropertyChanged("test");
        //    }
        //}

        //private string _teststring;
        //public string teststring
        //{
        //    get
        //    { return _teststring; }
        //    set
        //    {
        //        _teststring = value;
        //        OnPropertyChanged(nameof(teststring));
        //    }
        //} 

        public DashboardStudent()
        {     
            InitializeComponent();
            //this.DataContext = this;
            //test = new student_test();
           
            //test.getTest();
            //MessageBox.Show($"{test.name} {test.nameClass}");

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
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

        }
    }
}
