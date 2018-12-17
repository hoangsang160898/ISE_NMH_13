using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StudentDAO

    {
        private static StudentDAO instance;
        private StudentDAO() { }
        public static StudentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentDAO();
                return instance;
            }
        }
        static SqlConnection con;
        // Log in va load thông tin
        public  static StudentDTO Login(string id, string pw)
        {
            string sTruyVan = @"select * from Student where IDStudent= '" + id + @"' and PassWord = '" + pw + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            StudentDTO student = new StudentDTO();

            student.Id= dt.Rows[0]["IDStudent"].ToString();
            student.Name = dt.Rows[0]["Name"].ToString();
            student.Gender = dt.Rows[0]["Gender"].ToString();
            student.Email = dt.Rows[0]["Email"].ToString();
            student.Phone = dt.Rows[0]["Phone"].ToString();
            student.DateofBith = dt.Rows[0]["BirthDay"].ToString();
            student.NameClass = dt.Rows[0]["nameClass"].ToString();
            student.SchoolYear = dt.Rows[0]["schoolYear"].ToString();
            DataProvider.CloseConnection(con);
            return student;
        }
        // Xem điểm của học sinh
        public static DataTable LoadMark(string id)
        {
            string sTruyVan = @"select a.NameSubject, b.Semester, b.FirstFifteenMinutes, b.SecondFifteenMinutes, b.ThirdFifteenMinutes, b.FirstFortyFiveMinutes, b.SecondFortyFiveMinutes, b.ThirdFortyFiveMinutes, b.SemesterMark, b.nameClass, b.schoolYear from Mark b join Subject a on b.IDSubject = a.IDSubject where b.IDStudent='" + id + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            DataProvider.CloseConnection(con);
            return dt;
        }
    
    }
}
