using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.BL
{
    class Cell
    {
        public Cell(char value, int x, int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }
        private char value;
        private int x;
        private int y;
        public char GetValue()
        {
            return value;
        }
        public void SetValue(char value)
        {
            this.value = value;
        }
        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public bool IsPacmanPresent()
        {
            if (value == 'P')
            {
                return true;
            }
            return false;
        }
        public bool IsGhostPresent(char ghostChar)
        {
            if (value == ghostChar)
            {
                return true;
            }
            return false;
        }
    }
}
