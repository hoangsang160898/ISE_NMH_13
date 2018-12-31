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
    public sealed partial class TeacherManageClasses : Page
    {
        private List<StudentDTO> users = new List<StudentDTO>();
        private List<StudentDTO> users2 = new List<StudentDTO>();
        public TeacherManageClasses()
        {
            users.Add(new StudentDTO { Id ="1612556",NameClass="12C1",SchoolYear="2018-2019",Name="Nguyen Hoang Sang", Type="Student", Status="Active",DateofBith="16/8/1998",Gender="Male",Email="test@gmail.com",Password="123",Phone="0123456789"});
            users.Add(new StudentDTO { Id = "1612556", Name = "Nguyen Hoang Sang", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1612557", Name = "Le Hoang Sang", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1512383", Name = "Nguyen Thuy Nhien", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1612553", Name = "Tran Ngoc Quang", Type = "Student", Status = "Deactive" });
 
            users2.Add(new StudentDTO { Id = "1612556", NameClass = "12C1", SchoolYear = "2018-2019", Name = "Nguyen Hoang Sang", Type = "Student", Status = "Active", DateofBith = "16/8/1998", Gender = "Male", Email = "test@gmail.com", Password = "123", Phone = "0123456789" });
            users2.Add(new StudentDTO { Id = "1612556", Name = "Nguyen Hoang Sang", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1612557", Name = "Le Hoang Sang", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1512383", Name = "Nguyen Thuy Nhien", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1612553", Name = "Tran Ngoc Quang", Type = "Student", Status = "Deactive" });
            users2.Add(new StudentDTO { Id = "1234523", Name = "Nguyen Van A", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1612336", Name = "Nguyen Van B", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1621556", Name = "Nguyen Van C", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1235562", Name = "Nguyen Van D", Type = "Student", Status = "Active" });
            users2.Add(new StudentDTO { Id = "1343564", Name = "Nguyen Van E", Type = "Student", Status = "Deactive" });
            InitializeComponent();
        }

        private void Window_Loaded_Student(object sender, RoutedEventArgs e)
        {
            listviewUser.ItemsSource = users;
            listviewUser2.ItemsSource = users2;
        }


        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
            //Select ở bảng left
        }

        private void SelectItem2(object sender, MouseButtonEventArgs e)
        {
            //Select ở bảng right
        }

        private void ComboBox_Classes_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void searchUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rb_add_Checked(object sender, RoutedEventArgs e)
        {
            comboboxLeft.Visibility = Visibility.Collapsed;
            controlLeft.Visibility = Visibility.Collapsed;
        }

        private void rb_trans_Checked(object sender, RoutedEventArgs e)
        {
            comboboxLeft.Visibility = Visibility.Visible;
            controlLeft.Visibility = Visibility.Visible;
        }
    }
}
