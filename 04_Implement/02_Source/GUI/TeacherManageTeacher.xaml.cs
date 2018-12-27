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
    public sealed partial class TeacherManageTeacher : Page
    {
        private List<TeacherDTO> users = new List<TeacherDTO>();
        public TeacherManageTeacher()
        {
           // users.Add(new TeacherDTO { NamePosition="Master",Id ="1612556",NameClass="12C1",SchoolYear="2018-2019",Name="Nguyen Hoang Sang", Type="Teacher", Status="Active",DateofBith="16/8/1998",Gender="Male",Email="test@gmail.com",Password="123",Phone="0123456789"});
          //  users.Add(new TeacherDTO { NamePosition = "Subject Teacher", Id = "1612556", Name = "Nguyen Hoang Sang", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1612557", Name = "Le Hoang Sang", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1512383", Name = "Nguyen Thuy Nhien", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1612553", Name = "Tran Ngoc Quang", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1234523", Name = "Nguyen Van A", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1612336", Name = "Nguyen Van B", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1621556", Name = "Nguyen Van C", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { NamePosition = "Homeroom Teacher", Id = "1235562", Name = "Nguyen Van D", Type = "Teacher", Status = "Active" });
            users.Add(new TeacherDTO { Id = "1343564", Name = "Nguyen Van E", Type = "Teacher", Status = "Active" });
            InitializeComponent();
        }

        private void Window_Loaded_Teacher(object sender, RoutedEventArgs e)
        {
            listviewUser.ItemsSource = users;    
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            btnDoneOfEdit.Visibility = Visibility.Visible;
            fullname_tc_infor.IsReadOnly =false;
            birthofday_tc_infor.IsReadOnly = false;
            email_tc_infor.IsReadOnly = false;
            gender_tc_infor.IsReadOnly = false;
            gender_tc_infor.IsEnabled = true;
            phone_tc_infor.IsReadOnly = false;
            position_tc_infor.IsEnabled = true;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            position_tc_infor.IsEnabled = false;
            gender_tc_infor.IsEnabled = false;
            fullname_tc_infor.IsReadOnly = true;
            birthofday_tc_infor.IsReadOnly = true;
            email_tc_infor.IsReadOnly = true;
            gender_tc_infor.IsReadOnly = true;
            phone_tc_infor.IsReadOnly = true;
        }


        private void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEdit.IsEnabled = true;

        }

        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
           TeacherDTO item = (TeacherDTO)listviewUser.SelectedItems[0];
            fullname_tc_infor.Text = item.Name;
            birthofday_tc_infor.Text = item.DateofBith;
            email_tc_infor.Text = item.Email;
            id_tc_infor.Text = item.Id;
            if (item.Gender == "Male")
            {
                gender_tc_infor.SelectedIndex = 1;
            }
            else if (item.Gender == "Female")
            {
                gender_tc_infor.SelectedIndex = 2;
            }
            else
            {
                gender_tc_infor.SelectedIndex = 0;
            }
            phone_tc_infor.Text = item.Phone;
            if(item.NamePosition == "Master")
            {
                position_tc_infor.SelectedIndex = 2;
            }
            else if(item.NamePosition == "Subject Teacher")
            {
                position_tc_infor.SelectedIndex = 0;
            }
            else if (item.NamePosition == "Homeroom Teacher")
            {
                position_tc_infor.SelectedIndex = 1;
            }
            else
            {
                position_tc_infor.SelectedIndex = 3;
            }
        }

        private void btnViewScore_Click(object sender, RoutedEventArgs e)
        {
            var window = new ReviewStudentScore();
            window.Show();
        }
    }
}
