using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cylinder_Circle.BL;

namespace Cylinder_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(2.0, 3.3);
            Cylinder c3 = new Cylinder(2.5, 8.3, "Del");
            List<Cylinder> c = new List<Cylinder>();
            c.Add(c1);
            c.Add(c2);
            c.Add(c3);
            foreach (Cylinder cy in c)
            {
                Console.WriteLine(cy.toString() + " " + cy.GetVolume());
            }
            Console.ReadKey();
        }
    }
}
