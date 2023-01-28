using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class Angle
    {
        public Angle(int degree, float minutes, char direction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;
        }
        public int degree;
        public float minutes;
        public char direction;
        public void ChangeAngle(int degree, float minutes, char direction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;
        }
        public string Position()
        {
            string position = degree + "\u00b0" + minutes + "\'" + direction;
            return position;
        }
    }
}