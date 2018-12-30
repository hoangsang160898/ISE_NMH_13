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
using BUS;
namespace GUI
{
    /// <summary>
    /// Interaction logic for test2.xaml
    /// </summary>
    public sealed partial class TeacherUpdateScore : Page
    {
        List<string> subjects = new List<string>();
        List<MarkDTO> marks = new List<MarkDTO>();
        List<String> classes = new List<string>();
        List<string> listSubject = new List<string>();
        public TeacherUpdateScore()
        {
           /* classes.Add("10C1");
            classes.Add("11C1");
            classes.Add("12C1");
            classes.Add("10C2");
            classes.Add("10C3");
            classes.Add("11C2");
            classes.Add("12C2");
            classes.Add("10C3");
            subjects.Add("All");
            subjects.Add("English");
            subjects.Add("Technology");
            subjects.Add("Math");
            subjects.Add("Information Technology");
            subjects.Add("Defense Education");
            marks.Add(new MarkDTO {Semester=4 ,NameClass="12C1",IDStudent="321312",FirstFifteenMinutesMark = 1, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "Information Technology" });
            marks.Add(new MarkDTO { NameClass = "12C2", IDStudent = "31312", FirstFifteenMinutesMark = 2, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "A" });
            marks.Add(new MarkDTO { NameClass = "12C3", IDStudent = "32312", FirstFifteenMinutesMark = 3, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "B" });
            marks.Add(new MarkDTO { NameClass = "12C2", IDStudent = "312", FirstFifteenMinutesMark = 4, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "C" });
            marks.Add(new MarkDTO { NameClass = "12C1", IDStudent = "312", FirstFifteenMinutesMark = 5, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "D" });
            marks.Add(new MarkDTO { NameClass = "12C2", IDStudent = "32112", FirstFifteenMinutesMark = 6, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "E" });
            marks.Add(new MarkDTO { NameClass = "12C13", IDStudent = "3312", FirstFifteenMinutesMark = 7, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "F" });
            marks.Add(new MarkDTO { NameClass = "12C2", IDStudent = "321312", FirstFifteenMinutesMark = 8, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "G" });
            marks.Add(new MarkDTO { NameClass = "12C5", IDStudent = "312", FirstFifteenMinutesMark = 9, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "H" });*/
            InitializeComponent();
        }

        private void Window_Loaded_User(object sender, RoutedEventArgs e)
        {
            //listviewUser.ItemsSource = marks;
            if (Global.Teacher.NamePosition == "PDT")
            {
                listSubject = SubjectBUS.loadListNameSubject();
                listSubject.Add("All");
                chooseSubject.ItemsSource = listSubject;
                chooseSubject.SelectedIndex = 0;

                chooseClass.ItemsSource = AcademicAffairsOfficeBUS.loadListClassToComboBox();
                chooseClass.SelectedIndex = 0;
               /* if (chooseSubject.SelectedValue.ToString() == "All")
                {

                    listviewUser.ItemsSource = MarkBUS.loadMark(Global.Student.Id, Global.Student.NameClass, Global.Student.SchoolYear, "1");
                }
                else
                {
                    // test.ItemsSource = MarkBUS.loadMark(Global.Student.Id, Global.Student.NameClass, Global.Student.SchoolYear, semester);
                    listviewUser.ItemsSource = MarkBUS.loadMark(Global.Student.Id, Global.Student.NameClass, Global.Student.SchoolYear, "1", chooseSubject.SelectedValue.ToString());
                }*/
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            btnEdit.Visibility = Visibility.Collapsed;
            btnDoneOfEdit.Visibility = Visibility.Visible;
            m15st_st_infor.IsReadOnly = false;
            m15nd_st_infor.IsReadOnly = false;
            m15rd_st_infor.IsReadOnly = false;
            m45st_st_infor.IsReadOnly = false;
            m45nd_st_infor.IsReadOnly = false;
            m45rd_st_infor.IsReadOnly = false;
            semester_st_infor.IsReadOnly = false;
        }

        private void btnDoneofEdit_click(object sender, RoutedEventArgs e)
        {
            btnEdit.Visibility = Visibility.Visible;
            btnDoneOfEdit.Visibility = Visibility.Collapsed;
            m15st_st_infor.IsReadOnly = true;
            m15nd_st_infor.IsReadOnly = true;
            m15rd_st_infor.IsReadOnly = true;
            m45st_st_infor.IsReadOnly = true;
            m45nd_st_infor.IsReadOnly = true;
            m45rd_st_infor.IsReadOnly = true;
            semester_st_infor.IsReadOnly = true;
        }
        
        private void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnEdit.IsEnabled = true;
        }

        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
            MarkDTO item = (MarkDTO)listviewUser.SelectedItems[0];
            //subject_st_infor.Text = item.IdSubject;
            fullname_st_infor.Text = item.IDStudent;
            id_st_infor.Text = item.IDStudent;
            class_st_infor.Text = item.NameClass;
            m15st_st_infor.Text = item.FirstFifteenMinutesMark.ToString();
            m15nd_st_infor.Text = item.SecondFifteenMinutesMark.ToString();
            m15rd_st_infor.Text = item.ThirdFifteenMinutesMark.ToString();
            m45st_st_infor.Text = item.FirstFortyFiveMinutesMark.ToString();
            m45nd_st_infor.Text = item.SecondFortyFiveMinutesMark.ToString();
            m45rd_st_infor.Text = item.ThirdFortyFiveMinutesMark.ToString();
            semester_st_infor.Text = item.Semester.ToString();
        }

        private void ComboBox_Classes_Loaded(object sender, RoutedEventArgs e)
        {
           /* var combo = sender as ComboBox;
            combo.ItemsSource = classes;
            combo.SelectedIndex = 0;*/
        }

        private void Combobox_Loaded_Subject(object sender, RoutedEventArgs e)
        {
          /*  var combo = sender as ComboBox;
            combo.ItemsSource = subjects;
            combo.SelectedIndex = 0;*/
        }
    }
}
