using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Student.BL
{
    class Staff : Person
    {
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }
        private string school;
        private double pay;
        public string GetSchool()
        {
            return school;
        }
        public override string toString()
        {
            return "Staff[Person[name = " + name + ", address = " + address + "],school = " + school + " ,pay = " + pay + "]";
        }
    }
}
