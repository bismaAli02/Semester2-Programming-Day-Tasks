using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Subjects
    {
        public Subjects()
        {

        }
        public Subjects(string code, int CH, string type, int fee)
        {
            this.code = code;
            this.CH = CH;
            this.type = type;
            this.fee = fee;
        }
        public string code;
        public int CH;
        public string type;
        public int fee;

        public int TotalCH(List<Subjects> subject, Subjects sub)
        {
            int totalCH = 0;
            foreach (var s in subject)
            {
                totalCH += s.CH;
            }
            totalCH += sub.CH;
            return totalCH;
        }
        public void Display()
        {
            Console.WriteLine("Subject code: " + this.code);
        }
    }
}
