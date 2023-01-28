using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public DegreeProgram()
        {

        }
        public DegreeProgram(string title, string duration, int seats, List<Subjects> OfferedSubjects)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.OfferedSubjects = OfferedSubjects;
        }
        public string title;
        public string duration;
        public int seats;
        public List<Subjects> OfferedSubjects = new List<Subjects>();
        public int TotalCreditHours()
        {
            int totalCH = 0;
            foreach (var subject in OfferedSubjects)
            {
                totalCH += subject.CH;
            }
            return totalCH;
        }
        public void DisplayDegree()
        {
            Console.WriteLine("Degree Title: " + title);
        }
    }
}
