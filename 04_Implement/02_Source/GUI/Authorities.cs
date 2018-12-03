using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Authorities
    {
        public int AuthorID { get; set; } // 3 quyền đăng nhập admin 1, student -1, teacher 1
        public string AuthorName { get; set; } 
        public string AuthorIcon { get; set; }
    }
    public class AuthoritiesManager
    {
        public static List<Authorities> GetAuthorities()
        {
            var list_Authorities = new List<Authorities>();
            list_Authorities.Add(new Authorities { AuthorID = 1, AuthorName="Teacher", AuthorIcon="img/icons/teacher_icon_white.png" });
            list_Authorities.Add(new Authorities { AuthorID = 0, AuthorName = "Student", AuthorIcon = "img/icons/student_icon_white.png" });
            list_Authorities.Add(new Authorities { AuthorID = -1, AuthorName = "Admin", AuthorIcon = "img/icons/admin_icon_white.png" });
            return list_Authorities;
        }
    }
}
