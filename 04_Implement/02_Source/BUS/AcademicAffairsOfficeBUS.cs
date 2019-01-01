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
            if (student.Id.Length <= 6)
                return false;
            if (student.Id[0] != 'H' || student.Id[0] != 'h')
                return false;
            if (student.Id[1] != 'S' || student.Id[1] != 's')
                return false;

            if (!TeacherBUS.marchBirthDay(student.DateofBith))
                return false;

            if (!TeacherBUS.marchEmail(student.Email))
                return false;


            return AcademicAffairsOfficeDAO.AddNewStudent(student);
        }
    }
}
