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
    public class TeacherDAO
    {
       /* private static TeacherDAO instance;
        private TeacherDAO() { }
        public static TeacherDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TeacherDAO();
                return instance;
            }
        }*/
        static SqlConnection con;
        // Login va load thong tin
        public static TeacherDTO Login(string id, string pw)
        {
            string sTruyVan = @"select * from Teacher where IDTeacher= '" + id + @"' and PassWord = '" + pw + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TeacherDTO teacher = new TeacherDTO();

            teacher.Id = dt.Rows[0]["IDTeacher"].ToString();
            teacher.Name = dt.Rows[0]["Name"].ToString();
            teacher.Gender = dt.Rows[0]["Gender"].ToString();
            teacher.Email = dt.Rows[0]["Email"].ToString();
            teacher.Phone = dt.Rows[0]["Phone"].ToString();
            teacher.DateofBith = dt.Rows[0]["BirthDay"].ToString();
            DataProvider.CloseConnection(con);
            return teacher;
        }

        // Giao vien chu nhiem xem diem cua tat ca cac mon o lop do minh chu nhiem
        public static DataTable LoadMarkMaster(string idteacher)
        {
            string sTruyVan = @"select e.NameSubject, c.Name, c.nameClass, c.schoolYear, d.Semester, d.FirstFifteenMinutes, d.SecondFifteenMinutes, d.ThirdFifteenMinutes, d.FirstFortyFiveMinutes, d.SecondFortyFiveMinutes, d.ThirdFortyFiveMinutes, d.SemesterMark, d.IDStudent, d.IDSubject
                                from Teacher a  join Class b on a.IDTeacher= b.IDMaster 
	                                            join Student c on c.nameClass = b.nameClass and c.schoolYear = b.schoolYear
	                                            join Mark d on d.IDStudent= c.IDStudent and d.nameClass= c.nameClass and d.schoolYear=c.schoolYear
	                                            join Subject e on d.IDSubject = e.IDSubject

                                where a.IDTeacher= '" + idteacher + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan,con);
            return dt;
        }

        // Giao vien bo mon xem diem cua hoc sinh do giao vien do day
        public static DataTable LoadMark(string idteacher)
        {
            string sTruyVan = @"select c.NameSubject, e.Name, d.nameClass, d.schoolYear, d.Semester, d.FirstFifteenMinutes, d.SecondFifteenMinutes, d.ThirdFifteenMinutes, d.FirstFortyFiveMinutes, d.SecondFortyFiveMinutes, d.ThirdFortyFiveMinutes, d.SemesterMark, d.IDStudent, d.IDSubject
                                        from Teacher a  join Teacher_Subject b on a.IDTeacher = b.IDTeacher
				                                        join Subject c on c.IDSubject = b.IDSubject 
				                                        join Mark d on d.IDSubject = b.IDSubject and d.IDTeacher = b.IDTeacher
				                                        join Student e on d.IDStudent = e.IDStudent
                                where a.IDTeacher=  '" + idteacher + "'";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            return dt;

        }
        // giao vien thay doi diem
        public static bool changeMark(string idStudent, string idSubject, string semester, float FirstFifteenMinutes, float SecondFifteenMinutes, float ThirdFifteenMinutes, float FirstFortyFiveMinutes, float SecondFortyFiveMinutes, float ThirdFortyFiveMinutes, float SemesterMark)
        {
            string sTruyVan = @"update Mark 
                                set FirstFifteenMinutes = "+ FirstFifteenMinutes + @", SecondFifteenMinutes ="+ SecondFifteenMinutes + ",ThirdFifteenMinutes ="+ ThirdFifteenMinutes + @", FirstFortyFiveMinutes="+ FirstFortyFiveMinutes + @", SecondFortyFiveMinutes="+ SecondFortyFiveMinutes + @", ThirdFortyFiveMinutes="+ ThirdFortyFiveMinutes + @", SemesterMark="+ SemesterMark + @"
                                where IDStudent = '"+ idStudent+@"',  IDSubject ='"+ idSubject + "',Semester='"+ semester + "'";
            con = DataProvider.OpenConnection();
            bool check = DataProvider.ExecuteQuery(sTruyVan, con);
            DataProvider.CloseConnection(con);
            return check;
            
        }

        public static bool changeMyInfomation(string idTeacher, string Name, string Gender, string Email, string Phone, string BirthDay)
        {
            string sCommand = @"update Teacher
                                set Name = N'" + Name + @"', Gender = '" + Gender + @"', Email = '" + Email + @"', Phone = '" + Phone + @"', BirthDay = '" + BirthDay + @"' 
                                where IDTeacher = '"+idTeacher+"'";
            con = DataProvider.OpenConnection();
            bool check = DataProvider.ExecuteQuery(sCommand, con);
            DataProvider.CloseConnection(con);
            return check;
        }
        

    }
}
