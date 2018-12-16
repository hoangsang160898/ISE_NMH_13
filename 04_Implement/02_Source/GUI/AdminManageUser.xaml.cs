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
    public sealed partial class AdminManageUser : Page
    {
        private List<PeopleDTO> users = new List<PeopleDTO>();
        public AdminManageUser()
        {
            users.Add(new PeopleDTO {Id ="1612556",Name="Nguyen Hoang Sang", Type="Student", Status="Active",DateofBith="16/8/1998",Gender="Male",Email="test@gmail.com",Password="123",Phone="0123456789"});
            users.Add(new PeopleDTO { Id = "1612556", Name = "Nguyen Hoang Sang", Type = "Student", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1612557", Name = "Le Hoang Sang", Type = "Teacher", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1512383", Name = "Nguyen Thuy Nhien", Type = "Student", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1612553", Name = "Tran Ngoc Quang", Type = "Student", Status = "Deactive" });
            users.Add(new PeopleDTO { Id = "1234523", Name = "Nguyen Van A", Type = "Student", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1612336", Name = "Nguyen Van B", Type = "Teacher", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1621556", Name = "Nguyen Van C", Type = "Student", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1235562", Name = "Nguyen Van D", Type = "Teacher", Status = "Active" });
            users.Add(new PeopleDTO { Id = "1343564", Name = "Nguyen Van E", Type = "Student", Status = "Deactive" });
            InitializeComponent();
        }

        private void Window_Loaded_User(object sender, RoutedEventArgs e)
        {
            listviewUser.ItemsSource = users;
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            btnDoneOfEdit.Visibility = Visibility.Visible;
            btnDelete.Visibility = Visibility.Visible;
            btnActive.Visibility = Visibility.Visible;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnDelete.Visibility = Visibility.Collapsed;
            btnActive.Visibility = Visibility.Collapsed;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            btnEdit.IsEnabled = false;
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnDelete.Visibility = Visibility.Collapsed;
            btnActive.Visibility = Visibility.Collapsed;
        }

        private void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEdit.IsEnabled = true;
        }

        private void btnActive_Click(object sender, RoutedEventArgs e)
        {
            btnEdit.IsEnabled = false;
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            btnDelete.Visibility = Visibility.Collapsed;
            btnActive.Visibility = Visibility.Collapsed;
        }

        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
            PeopleDTO item = (PeopleDTO)listviewUser.SelectedItems[0];
            fullname_user_infor.Text = item.Name;
            birthofday_user_infor.Text = item.DateofBith;
            email_user_infor.Text = item.Email;
            password_user_infor.Password = item.Password;
            gender_user_infor.Text = item.Gender;
            phone_user_infor.Text = item.Phone;
            author_user_infor.Text = item.Type;
            if (item.Status == "Active")
            {
                btnDelete.Visibility = Visibility.Visible;
            }else if (item.Status == "Deactive")
            {
                btnActive.Visibility = Visibility.Visible;
            }
        }
    }
}
