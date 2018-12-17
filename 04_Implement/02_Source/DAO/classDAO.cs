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
   public class classDAO
    {
        static SqlConnection con;
        private static classDAO instance;
        private classDAO() { }
        public static classDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new classDAO();
                return instance;
            }
        }
        // hàm load danh sách lớp học (để đưa vào comboBox)
        public static List<ClassDTO> loadListClass()
        {
            string sTruyVan = @"Select* from Class";
            con = DataProvider.OpenConnection();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ClassDTO> result = new List<ClassDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClassDTO Class = new ClassDTO();
                Class.Name = dt.Rows[i]["nameClass"].ToString();
                Class.SchoolYear = dt.Rows[i]["schoolYear"].ToString();
                Class.IdMaster = dt.Rows[i]["IDMaster"].ToString();
                result.Add(Class);
            }
            DataProvider.CloseConnection(con);
            return result;
        }
    }
}
