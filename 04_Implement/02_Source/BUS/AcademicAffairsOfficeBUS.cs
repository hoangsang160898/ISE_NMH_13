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

        public static List<StudentDTO> searchStudentByName(string nameStudent, string nameClass, string schoolYear)
        {
            var result = AcademicAffairsOfficeDAO.searchStudentByName(nameStudent, nameClass, schoolYear);
            int n = result.Count;
            for (int i=0;i<n;i++)
            {
                string temp = result[i].DateofBith;
                TeacherBUS.StandalizedBirthDayToUI(ref temp);
                result[i].DateofBith = temp;
            }
            return result;
        }
    }
}
