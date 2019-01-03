using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class AcademicAffairsOfficeBUS
    {
        private static AcademicAffairsOfficeBUS instance;
        private AcademicAffairsOfficeBUS() {}

        public static AcademicAffairsOfficeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AcademicAffairsOfficeBUS();
                return instance;
            }
        }

        public static List<string> loadListClassToComboBox()
        {
            return AcademicAffairsOfficeDAO.loadListClassToComboBox();
        }

        public static List<string> loadListClassToComboBox(string schoolYear)
        {
            return AcademicAffairsOfficeDAO.loadListClassToComboBox(schoolYear);
        }

        public static List<string> loadListSchoolYearToComboBox()
        {
            return AcademicAffairsOfficeDAO.loadSchoolYearToComboBox();
        }

        public static List<StudentDTO> loadListStudent(string nameClass, string SchoolYear)
        {
            var result = AcademicAffairsOfficeDAO.LoadStudent(nameClass, SchoolYear);
            int n = result.Count;
            for (int i = 0; i < n; i++)
            {
                string temp = result[i].DateofBith;
                TeacherBUS.StandalizedBirthDayToUI(ref temp);
                result[i].DateofBith = temp;
            }
            return result;
        }

        public static List<StudentDTO> searchStudent(string textToSearch, string nameClass, string schoolYear)
        {
            var result = AcademicAffairsOfficeDAO.searchStudent(textToSearch, nameClass, schoolYear);
            if (result == null)
                return null;
            int n = result.Count;
            for (int i=0;i<n;i++)
            {
                string temp = result[i].DateofBith;
                TeacherBUS.StandalizedBirthDayToUI(ref temp);
                result[i].DateofBith = temp;
            }
            return result;
        }

        public static bool addNewStudent(StudentDTO student)
        {
            // kiểm tra định dạng IDStudent
            if (student.Id.Length <= 4)
                return false;
            if (student.Id[0] != 'H')
                return false;
            if (student.Id[1] != 'S')
                return false;

            if (!TeacherBUS.marchBirthDay(student.DateofBith))
                return false;

            if (!TeacherBUS.marchEmail(student.Email))
                return false;

            string birthDay = student.DateofBith;
            TeacherBUS.StandalizedBirthDayToDatabase(ref birthDay);
            student.DateofBith = birthDay;
            return AcademicAffairsOfficeDAO.AddNewStudent(student);
        }

        public static List<StudentDTO> loadStudentNotInClass(string schoolYear)
        {
            return AcademicAffairsOfficeDAO.loadStudentNotInClass(schoolYear);
        }

        public static List<StudentDTO> searchStudentNotInClass(string textToSearch, string schoolYear)
        {
            return AcademicAffairsOfficeDAO.searchStudentNotInClass(textToSearch, schoolYear);
        }

        public static List<StudentDTO> LoadStudent(string nameClass, string schoolYear, string status)
        {
            List<StudentDTO> result= AcademicAffairsOfficeDAO.LoadStudent(nameClass, schoolYear, status);
            if (result != null)
            {
                int n = result.Count;
                for (int i=0;i<n;i++)
                {
                    string birthDay = result[i].DateofBith;
                    TeacherBUS.StandalizedBirthDayToUI(ref birthDay);
                    result[i].DateofBith = birthDay;
                }
                return result;
            }
            return null;
        } 

        public static bool InsertStudentToClass(string IDStudent, string nameClass, string schoolYear)
        {
            return AcademicAffairsOfficeDAO.InsertStudentToClass(IDStudent, nameClass, schoolYear);
        }

        public static bool updateClass(string IDStudent, string nameClass, string schoolYear)
        {
            return classDAO.updateClass(IDStudent, nameClass, schoolYear);
        }

        public static bool InsertMark(MarkDTO mark)
        {
            return AcademicAffairsOfficeDAO.InsertMark(mark);
        }

        public static bool updateInfoStudent(StudentDTO student)
        {
            string birthDay = student.DateofBith;

            if (!TeacherBUS.marchBirthDay(student.DateofBith))
                return false;

            if (!TeacherBUS.marchEmail(student.Email))
                return false;

            TeacherBUS.StandalizedBirthDayToDatabase(ref birthDay);
            student.DateofBith = birthDay;
            return AcademicAffairsOfficeDAO.updateInfoStudent(student);
        }

        public static bool deActiveStudent(string IDStudent)
        {
            return AcademicAffairsOfficeDAO.deActiveStudent(IDStudent);
        }

        public static bool ActiveStudent(string IDStudent)
        {
            return AcademicAffairsOfficeDAO.ActiveStudent(IDStudent);
        }

        public static List<TeacherDTO> loadListTeacher()
        {
            List<TeacherDTO> result = AcademicAffairsOfficeDAO.loadListTeacher();
            if (result != null)
            {
                int n = result.Count;
                for (int i=0;i<n;i++)
                {
                    if (result[i].Type == "PDT")
                    {
                        result[i].NamePosition = "Academic Affair Offfice Staff";
                    }
                    else if (AcademicAffairsOfficeDAO.isMaster(result[i].Id,"2018-2019"))
                    {
                        result[i].NamePosition = "Homeroom Teacher";
                    }
                    else
                    {
                        result[i].NamePosition = "Subject Teacher";
                    }

                    string birthDay = result[i].DateofBith;
                    TeacherBUS.StandalizedBirthDayToUI(ref birthDay);
                    result[i].DateofBith = birthDay;
                }
                return result;
            }
            return null;
        }


        public static List<TeacherDTO> loadListHomeRoomTeacher(string schoolYear)
        {
            List<TeacherDTO> result = AcademicAffairsOfficeDAO.loadListHomeRoomTeacher(schoolYear);
            if (result != null)
            {
                int n = result.Count;
                for (int i = 0; i < n; i++)
                {
                    string birthDay = result[i].DateofBith;
                    TeacherBUS.StandalizedBirthDayToUI(ref birthDay);
                    result[i].DateofBith = birthDay;
                }
                return result;
            }
            return null;
        }
        public static List<TeacherDTO> loadListAAOS()
        {
            List<TeacherDTO> result = AcademicAffairsOfficeDAO.loadListAAOS();
            if (result != null)
            {
                int n = result.Count;
                for (int i = 0; i < n; i++)
                {
                    string birthDay = result[i].DateofBith;
                    TeacherBUS.StandalizedBirthDayToUI(ref birthDay);
                    result[i].DateofBith = birthDay;
                }
                return result;
            }
            return null;
        }
        public static List<TeacherDTO> loadListSubjectTeacher(string schoolYear)
        {

            List<TeacherDTO> result = AcademicAffairsOfficeDAO.loadListSubjectTeacher(schoolYear);
            if (result != null)
            {
                int n = result.Count;
                for (int i = 0; i < n; i++)
                {
                    string birthDay = result[i].DateofBith;
                    TeacherBUS.StandalizedBirthDayToUI(ref birthDay);
                    result[i].DateofBith = birthDay;
                }
                return result;
            }
            return null;

        }

        public static List<TeacherDTO> searchTeacher(string textToSearch, string schoolYear, string position)
        {
            List<TeacherDTO> result = AcademicAffairsOfficeDAO.searchTeacher(textToSearch, schoolYear, position);
            if (result != null)
            {
                int n = result.Count;
                for (int i = 0; i < n; i++)
                {
                    string birthDay = result[i].DateofBith;
                    TeacherBUS.StandalizedBirthDayToUI(ref birthDay);
                    result[i].DateofBith = birthDay;

                    if (position == "System.Windows.Controls.ComboBoxItem: All")
                    {
                        if (result[i].Type == "PDT")
                        {
                            result[i].NamePosition = "Academic Affair Offfice Staff";
                        }
                        else if (AcademicAffairsOfficeDAO.isMaster(result[i].Id, "2018-2019"))
                        {
                            result[i].NamePosition = "Homeroom Teacher";
                        }
                        else
                        {
                            result[i].NamePosition = "Subject Teacher";
                        }
                    }
                }
                return result;
            }
            return null;
        }

        public static bool isMaster(string IDTeacher, string schoolYear)
        {
            return AcademicAffairsOfficeDAO.isMaster(IDTeacher, schoolYear);
        }
        public static int getSumStudent(string nameClass, string schoolYear)
        {
            return AcademicAffairsOfficeDAO.getSumStudent(nameClass, schoolYear);
        }
    }
}
