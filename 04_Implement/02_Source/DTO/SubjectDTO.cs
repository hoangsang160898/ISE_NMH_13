using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SubjectDTO
    {
        private string idSubject;
        private string nameSubject;
        private double firstFifteenMinutesMark;
        private double secondFifteenMinutesMark;
        private double thirdFifteenMinutesMark;
        private double firstFortyFiveMinutesMark;
        private double secondFortyFiveMinutesMark;
        private double thirdFortyFiveMinutesMark;
        private double semesterScore;
        private double averageMark;

        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string NameSubject { get => nameSubject; set => nameSubject = value; }
        public double FirstFifteenMinutesMark { get => firstFifteenMinutesMark; set => firstFifteenMinutesMark = value; }
        public double SecondFifteenMinutesMark { get => secondFifteenMinutesMark; set => secondFifteenMinutesMark = value; }
        public double ThirdFifteenMinutesMark { get => thirdFifteenMinutesMark; set => thirdFifteenMinutesMark = value; }
        public double FirstFortyFiveMinutesMark { get => firstFortyFiveMinutesMark; set => firstFortyFiveMinutesMark = value; }
        public double SecondFortyFiveMinutesMark { get => secondFortyFiveMinutesMark; set => secondFortyFiveMinutesMark = value; }
        public double ThirdFortyFiveMinutesMark { get => thirdFortyFiveMinutesMark; set => thirdFortyFiveMinutesMark = value; }
        public double SemesterScore { get => semesterScore; set => semesterScore = value; }
        public double AverageMark { get => averageMark; set => averageMark = value; }

        public SubjectDTO()
        {
            idSubject = NameSubject = "";
            firstFifteenMinutesMark = secondFifteenMinutesMark = thirdFifteenMinutesMark = 0;
            FirstFortyFiveMinutesMark = SecondFortyFiveMinutesMark = ThirdFortyFiveMinutesMark = 0;
            semesterScore = 0;
            averageMark = 0;
        }
    }
}
