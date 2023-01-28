using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder_Circle.BL
{
    class Cylinder : Circle
    {
        public Cylinder()
        {
            hieght = 1.0;
        }
        public Cylinder(double radius) : base(radius)
        {
            hieght = 1.0;
        }
        public Cylinder(double radius, double hieght) : base(radius)
        {
            this.hieght = hieght;
        }
        public Cylinder(double radius, double hieght, string color) : base(radius, color)
        {
            this.hieght = hieght;
        }
        private double hieght;
        public double GetHieght()
        {
            return hieght;
        }
        public void SetHieght(double hieght)
        {
            this.hieght = hieght;
        }
        public double GetVolume()
        {
            double A = GetArea();
            return (A * hieght);
        }
    }
}
