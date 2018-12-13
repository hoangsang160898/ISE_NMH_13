using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class student_test
    {
       public string name;
        public string id;
        public string password;
        public string type;
        public string dateofBith;
        public string gender;
        public string email;
        public string phone;
      public string nameClass;
        public List<int> years = new List<int>();
        public void getTest()
        {
            List<int> test = new List<int> { 1992, 1993, 1994, 1995 };

            this.name = "Test Leo Nguyen";
            this.dateofBith = "01.01.1998";
            this.gender = "Test Male";
            this.email = "test@student.hcmus.edu.vn";
            this.phone = "0123456789";
            this.nameClass = "K16 test";

        }
    }

}
