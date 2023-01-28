using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder_Circle.BL
{
    class Circle
    {
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            color = "red";
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        protected double radius;
        protected string color;
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public double GetRadius()
        {
            return radius;
        }
        public string GetColor()
        {
            return color;
        }
        public string toString()
        {
            return "Circle[ radius = " + radius + " , color = " + color + "]";
        }
        public double GetArea()
        {
            return (3.14 * radius * radius);
        }
    }
}
