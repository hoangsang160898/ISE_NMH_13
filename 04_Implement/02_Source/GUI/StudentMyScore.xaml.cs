﻿using System;
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
    public partial class StudentMyScore : Page
    {
        List<MarkDTO> marks = new List<MarkDTO>();
        List<string> subjects = new List<string>();
        public StudentMyScore()
        {
          /*  marks.Add(new MarkDTO { FirstFifteenMinutesMark = 1, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "Information Technology" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 2, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "A" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 3, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "B" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 4, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "C" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 5, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "D" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 6, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "E" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 7, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "F" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 8, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "G" });
            marks.Add(new MarkDTO { FirstFifteenMinutesMark = 9, SecondFifteenMinutesMark = 5, ThirdFifteenMinutesMark = 9, FirstFortyFiveMinutesMark = 10, SecondFortyFiveMinutesMark = 3, ThirdFortyFiveMinutesMark = 8.5, SemesterScore = 9.5, IdSubject = "H" });
            subjects.Add("All");
            subjects.Add("English");
            subjects.Add("Technology");
            subjects.Add("Math");
            subjects.Add("Information Technology");
            subjects.Add("Defense Education");*/
            InitializeComponent();
        }

        private void Window_Loaded_Score(object sender, RoutedEventArgs e)
        {
            var testGUI = marks;
            test.ItemsSource = testGUI;         
        }

        private void Combobox_Loaded_Subject(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = subjects;
            
            combo.SelectedIndex = 0;
        }
    }
}