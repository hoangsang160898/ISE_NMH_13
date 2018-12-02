using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    class AcademicAffairsOfficeDAO
    {
        // load danh sách sinh viên theo lớp, theo năm học
        static SqlConnection con;
        public static List<StudentDTO> LoadStudent(string className, string SchoolYear)
        {
            string sTruyVan = @"Select IDStudent, Name, Gender,Email, Phone, BirthDay from Student where nameClass = " + className + @" and ClassSchoolYear = " + SchoolYear;
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<StudentDTO> result = new List<StudentDTO>();
            for (int i=0;i<dt.Rows.Count;i++)
            {
                StudentDTO student = new StudentDTO();
                student.Id = dt.Rows[i]["IDStudent"].ToString();
                student.Name = dt.Rows[i]["Name"].ToString();
                student.Gender = dt.Rows[i]["Gender"].ToString();
                student.Email = dt.Rows[i]["Email"].ToString();
                student.Phone = dt.Rows[i]["Phone"].ToString();
                student.DateofBith = dt.Rows[i]["BirthDay"].ToString();
                result.Add(student);
            }
            return result;
        }
    }
}
