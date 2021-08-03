using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook_
{
    class User
    {
        public User() { }
        public User(string fullname, DateTime date, string attend, int grade, int gradeInClass, int diamondCount, string teachersOpinion)
        {
            Fullname = fullname;
            Date = date;
            Attend = attend;
            Grade = grade;
            GradeInClass = gradeInClass;
            DiamondCount = diamondCount;
            TeachersOpinion = teachersOpinion;
        }

        public string Fullname { get; set; }
        public DateTime Date { get; set; }
        public string Attend { get; set; }
        public int Grade { get; set; }
        public int GradeInClass { get; set; }
        public int DiamondCount { get; set; }
        public string TeachersOpinion { get; set; }

    }
   

}
