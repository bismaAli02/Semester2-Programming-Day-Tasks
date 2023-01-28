using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Student.BL
{
    class Person
    {
        public Person()
        {

        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected string name;
        protected string address;
        public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return "Person[name = " + name + " , address = " + address + "]";
        }
    }
}
