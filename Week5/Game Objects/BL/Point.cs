using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Objects.BL
{
    class Point
    {
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetX()
        {
            return x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetY()
        {
            return y;
        }
        public void SetXY(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

    }
}
