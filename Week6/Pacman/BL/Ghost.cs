using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;

namespace Pacman.BL
{
    class Ghost
    {
        private int X;
        private int Y;
        private string ghostDirection;
        private char ghostCharacter;
        private float speed;
        private char previousItem;
        private float deltaChange;
        private Grid mazeGrid;
        public Ghost(int X, int Y, char ghostCharacter, string ghostDirection, float speed, char previousItems, Grid mazeGrid)
        {
            this.X = X;
            this.Y = Y;
            this.ghostCharacter = ghostCharacter;
            this.ghostDirection = ghostDirection;
            this.speed = speed;
            this.previousItem = previousItems;
            this.mazeGrid = mazeGrid;
        }
        public void setDirection(string ghostDirection)
        {
            this.ghostDirection = ghostDirection;
        }
        public string getDirection()
        {
            return ghostDirection;
        }
        public void remove()
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(previousItem);
        }
        public void draw()
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(ghostCharacter);
            Cell c = mazeGrid.GetCell(X, Y);
            c.SetValue(ghostCharacter);
        }
        public char getCharacter()
        {
            return ghostCharacter;
        }
        public void changeDelta()
        {
            deltaChange = deltaChange + speed;
        }
        public float getDelta()
        {
            return deltaChange;
        }
        public void setDeltaZero()
        {
            deltaChange = 0;
        }
        public void move()
        {
            changeDelta();
            if (Math.Floor(getDelta()) == 1)
            {
                if (ghostCharacter == 'H')
                {
                    MoveHorizontal();
                }
                if (ghostCharacter == 'V')
                {
                    MoveVertical();
                }
                setDeltaZero();
            }
        }
        public void MoveHorizontal()
        {
            Cell g = mazeGrid.FindGhost('H');
            if (g != null)
            {

                if (ghostDirection == "left")
                {
                    Cell left = mazeGrid.GetLeftCell(g);
                    if (left.GetValue() == ' ' || left.GetValue() == '.')
                    {
                        g.SetValue(previousItem);
                        previousItem = left.GetValue();
                        left.SetValue('H');
                        Y--;
                    }
                    if (left.GetValue() == '|' || left.GetValue() == '#' || left.GetValue() == '%')
                    {
                        ghostDirection = "right";
                    }
                }
                else if (ghostDirection == "right")
                {
                    Cell right = mazeGrid.GetRightCell(g);
                    if (right.GetValue() == ' ' || right.GetValue() == '.')
                    {
                        g.SetValue(previousItem);
                        previousItem = right.GetValue();
                        right.SetValue('H');
                        Y++;
                    }
                    if (right.GetValue() == '|' || right.GetValue() == '#' || right.GetValue() == '%')
                    {
                        ghostDirection = "left";
                    }
                }
            }

        }
        public void MoveVertical()
        {
            Cell g = mazeGrid.FindGhost('V');
            if (g != null)
            {

                if (ghostDirection == "up")
                {
                    Cell up = mazeGrid.GetUpCell(g);
                    if (up.GetValue() == ' ' || up.GetValue() == '.')
                    {
                        g.SetValue(previousItem);
                        previousItem = up.GetValue();
                        up.SetValue('V');
                        X--;
                    }
                    if (up.GetValue() == '|' || up.GetValue() == '#' || up.GetValue() == '%')
                    {
                        ghostDirection = "down";
                    }
                }
                else if (ghostDirection == "down")
                {
                    Cell down = mazeGrid.GetDownCell(g);
                    if (down.GetValue() == ' ' || down.GetValue() == '.')
                    {
                        g.SetValue(previousItem);
                        previousItem = down.GetValue();
                        down.SetValue('H');
                        X++;
                    }
                    if (down.GetValue() == '|' || down.GetValue() == '#' || down.GetValue() == '%')
                    {
                        ghostDirection = "up";
                    }
                }
            }

        }

    }
}
