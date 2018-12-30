using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class MarkBUS
    {
        private static MarkBUS instance;
        private MarkBUS() { }
        public MarkBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MarkBUS();
                return instance;
            }
        }

        public static List<MarkDTO> loadMark(string idStudent, string nameClass, string schoolYear, string semester)
        {
            return MarkDAO.loadMark(idStudent, nameClass, schoolYear, semester);
        }
        public static List<MarkDTO> loadMark(string idStudent, string nameClass, string schoolYear, string semester, string nameSubject)
        {
            return MarkDAO.loadMark(idStudent, nameClass, schoolYear, semester, nameSubject);
        }
    }

}
