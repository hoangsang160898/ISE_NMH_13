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
        public static string getNameStudent(string id)
        {
            return MarkDAO.getNameStudent(id);
        }

        public static List<MarkDTO> loadMarkByNameSubject(string nameSubject, string nameClass, string schoolYear, string semester)
        {
            return MarkDAO.loadMarkByNameSubject(nameSubject, nameClass, schoolYear, semester);
        }

        public static List<MarkDTO> loadMarkByClass(string nameClass, string schoolYear, string semester)
        {
            return MarkDAO.loadMarkByClass(nameClass, schoolYear, semester);
        }

        public static List<MarkDTO> searchStudent_Mark(string keyWord, string nameSubject, string nameClass, string schoolYear, string semester)
        {
            return MarkDAO.searchStudent_Mark(keyWord, nameSubject, nameClass, schoolYear, semester);
        }

        public static bool UpdateScore(string idStudent, string nameClass, string schoolYear, string idSubject,string semester, MarkDTO mark)
        {
            return MarkDAO.UpdateScore(idStudent, nameClass, schoolYear, idSubject,semester, mark);
        }

        public static bool removeMark(string IDStudent, string nameClass, string schoolYear)
        {
            return MarkDAO.removeMark(IDStudent, nameClass, schoolYear);
        }


    }

}
