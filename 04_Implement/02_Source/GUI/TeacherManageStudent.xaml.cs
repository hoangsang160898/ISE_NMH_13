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
    public sealed partial class TeacherManageStudent : Page
    {
        private List<StudentDTO> users = new List<StudentDTO>();
        public TeacherManageStudent()
        {
            users.Add(new StudentDTO { Id ="1612556",NameClass="12C1",SchoolYear="2018-2019",Name="Nguyen Hoang Sang", Type="Student", Status="Active",DateofBith="16/8/1998",Gender="Male",Email="test@gmail.com",Password="123",Phone="0123456789"});
            users.Add(new StudentDTO { Id = "1612556", Name = "Nguyen Hoang Sang", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1612557", Name = "Le Hoang Sang", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1512383", Name = "Nguyen Thuy Nhien", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1612553", Name = "Tran Ngoc Quang", Type = "Student", Status = "Deactive" });
            users.Add(new StudentDTO { Id = "1234523", Name = "Nguyen Van A", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1612336", Name = "Nguyen Van B", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1621556", Name = "Nguyen Van C", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1235562", Name = "Nguyen Van D", Type = "Student", Status = "Active" });
            users.Add(new StudentDTO { Id = "1343564", Name = "Nguyen Van E", Type = "Student", Status = "Deactive" });
            InitializeComponent();
        }

        private void Window_Loaded_Student(object sender, RoutedEventArgs e)
        {
            listviewUser.ItemsSource = users;

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            btnDoneOfEdit.Visibility = Visibility.Visible;
            fullname_st_infor.IsReadOnly =false;
            birthofday_st_infor.IsReadOnly = false;
            email_st_infor.IsReadOnly = false;
            class_st_infor.IsReadOnly = false;
   
            phone_st_infor.IsReadOnly = false;
            schoolyear_st_infor.IsReadOnly = false;
            gender_st_infor.IsEnabled = true;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            gender_st_infor.IsEnabled = false ;
            fullname_st_infor.IsReadOnly = true;
            birthofday_st_infor.IsReadOnly = true;
            email_st_infor.IsReadOnly = true;
            class_st_infor.IsReadOnly = true;
            phone_st_infor.IsReadOnly = true;
            schoolyear_st_infor.IsReadOnly = true;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            btnDelete.Visibility = Visibility.Collapsed;
            btnActive.Visibility = Visibility.Visible;
        }

        private void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEdit.IsEnabled = true;
            btnViewScore.IsEnabled = true;
        }

        private void btnActive_Click(object sender, RoutedEventArgs e)
        {
            btnDelete.Visibility = Visibility.Visible;
            btnActive.Visibility = Visibility.Collapsed;
        }

        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
            StudentDTO item = (StudentDTO)listviewUser.SelectedItems[0];
            fullname_st_infor.Text = item.Name;
            birthofday_st_infor.Text = item.DateofBith;
            email_st_infor.Text = item.Email;
            class_st_infor.Text = item.NameClass;
            if (item.Gender == "Male")
            {
                gender_st_infor.SelectedIndex = 1;
            }
            else if (item.Gender == "Female")
            {
                gender_st_infor.SelectedIndex = 2;
            }
            else
            {
                gender_st_infor.SelectedIndex = 0;
            }
            phone_st_infor.Text = item.Phone;
            schoolyear_st_infor.Text = item.SchoolYear;
            if (item.Status == "Active")
            {
               btnDelete.Visibility = Visibility.Visible;
                btnActive.Visibility = Visibility.Collapsed;
            }
            else if (item.Status == "Deactive")
            {
                btnActive.Visibility = Visibility.Visible;
                btnDelete.Visibility = Visibility.Collapsed;
            }
        }

        private void btnViewScore_Click(object sender, RoutedEventArgs e)
        {
            var window = new ReviewStudentScore();
            window.Show();
        }

        private void ComboBox_Classes_Loaded(object sender, RoutedEventArgs e)
        {
            /* if (Global.Teacher.NamePosition == "PDT")
             {
                 var combo = sender as ComboBox;
                 combo.ItemsSource = AcademicAffairsOfficeBUS.loadListClassToComboBox();
                 combo.SelectedIndex = 0;
             }
             else
             {
                 var combo = sender as ComboBox;
                 combo.ItemsSource = classes;
                 combo.SelectedIndex = 0;
             }*/
        }
    }
}
