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
            return AcademicAffairsOfficeDAO.LoadStudent(nameClass, schoolYear, status);
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
    }
}
