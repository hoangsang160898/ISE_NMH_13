using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubjectDTO
    {
        private string idSubject;
        private string nameSubject;
    

        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string NameSubject { get => nameSubject; set => nameSubject = value; }
       

        public SubjectDTO()
        {
            idSubject = NameSubject = "";
        }
    }
}
