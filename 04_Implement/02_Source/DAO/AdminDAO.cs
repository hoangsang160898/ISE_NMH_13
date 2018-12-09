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
    class AdminDAO
    {
        private static AdminDAO instance;

        private AdminDAO() { }

        public static AdminDAO Instance()
        {
            if (instance == null)
            {
                instance = new AdminDAO();
            }
            return instance;
        }

        static SqlConnection con;

        // load danh sách giáo viên từ db
        public static List<TeacherDTO> LoadTeacher()
        {
            List<TeacherDTO> result = new List<TeacherDTO>();

            string sTruyVan = @"Select * From Teacher";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TeacherDTO teacher = new TeacherDTO();
                teacher.Id = dt.Rows[i]["IDTeacher"].ToString();
                teacher.Name = dt.Rows[i]["Name"].ToString();
                teacher.Gender = dt.Rows[i]["Name"].ToString();
                teacher.Email = dt.Rows[i]["Email"].ToString();
                teacher.Phone = dt.Rows[i]["Phone"].ToString();
                teacher.DateofBith = dt.Rows[i]["BirthDay"].ToString();
                teacher.Password = dt.Rows[i]["PassWord"].ToString();
                result.Add(teacher);
            }
            DataProvider.CloseConnection(con);
            return result;
        }

        //xem thông tin giáo viên từ db
        public static DataTable LoadInfo(string idTeacher)
        {
            string sCommand = @"Select * from Teacher where Teacher.IDTeacher = N'" + idTeacher + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sCommand, con);
            DataProvider.CloseConnection(con);
            return dt;
        }

        //cập nhật điểm vào db
        public static bool changeMark(string idStudent, string subject, string Class, string schoolYear, string semester
            , float FirstFifteenMinutes, float SecondFifteenMinutes
            , float ThirdFifteenMinutes, float FirstFortyFiveMinutes
            , float SecondFortyFiveMinutes, float ThirdFortyFiveMinutes
            , float SemesterMark)
        {
            con = DataProvider.OpenConnection();
            try
            {
                string sTruyVan = @"UPDATE Mark 
                                SET FirstFifteenMinutes = " + FirstFifteenMinutes + @", SecondFifteenMinutes =" + SecondFifteenMinutes + ",ThirdFifteenMinutes =" + ThirdFifteenMinutes + @", FirstFortyFiveMinutes=" + FirstFortyFiveMinutes + @", SecondFortyFiveMinutes=" + SecondFortyFiveMinutes + @", ThirdFortyFiveMinutes=" + ThirdFortyFiveMinutes + @", SemesterMark=" + SemesterMark + @"
                                WHERE IDStudent = N'" + idStudent + @"'and  IDSubject ='" + subject + @"'and Semester='" + semester + @"'and nameClass='" + Class + @"'and schoolYear='" + schoolYear + "'";
                DataProvider.ExecuteQuery(sTruyVan, con);
                DataProvider.CloseConnection(con);
                return true;
            }
            catch(Exception ex)
            {
                DataProvider.CloseConnection(con);
                return false;
            }          
        }

        //reset mật khẩu
        public static bool resetPassword(string user)
        {
            PeopleDTO Object = new PeopleDTO();
            string type = Object.GetType().ToString();
            con = DataProvider.OpenConnection();
            if(type == "Student")
            {
                try
                {
                    string sCommand = @"UPDATE Student SET PassWord = '123456' WHERE IDStudent = N'" + user + "'";
                    DataProvider.ExecuteQuery(sCommand, con);
                    DataProvider.CloseConnection(con);
                    return true;
                }
                catch(Exception ex)
                {
                    DataProvider.CloseConnection(con);
                    return false;
                }
            }
            if (type == "Teacher")
            {
                try
                {
                    string sCommand = @"UPDATE Teacher SET PassWord = '123456' WHERE IDTeacher = N'" + user + "'";
                    DataProvider.ExecuteQuery(sCommand, con);
                    DataProvider.CloseConnection(con);
                    return true;
                }
                catch (Exception ex)
                {
                    DataProvider.CloseConnection(con);
                    return false;
                }
            }
            return false;
        }




}
