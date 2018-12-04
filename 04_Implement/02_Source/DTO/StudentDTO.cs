using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO:PeopleDTO
    {
        private string nameClass;
        private string schoolYear;
        public StudentDTO()
        {
            NameClass = SchoolYear = "";
        }

        public string NameClass { get => nameClass; set => nameClass = value; }
        public string SchoolYear { get => schoolYear; set => schoolYear = value; }
    }
}
