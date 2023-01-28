using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Objects.BL
{
    class GameObject
    {
        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape, Point StartingPoint)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape, Point StartingPoint, Boundary Premises, string Direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
        }
        public char[,] Shape;
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public void Erase()
        {
            for (int i = StartingPoint.GetX(); i < StartingPoint.GetX() + 5; i++)
            {
                for (int j = StartingPoint.GetY(); j < StartingPoint.GetY() + 3; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
            }
        }
        public void Move()
        {
            if (Direction == "LeftToRight")
            {
                if (StartingPoint.y != 90)
                {
                    StartingPoint.SetY(StartingPoint.GetY() + 1);
                }
            }
            else if (Direction == "RightToLeft")
            {
                if (StartingPoint.y != 0)
                {
                    StartingPoint.SetY(StartingPoint.GetY() - 1);
                }
            }
            else if (Direction == "Patrol")
            {
                if (StartingPoint.y == 0)
                {
                    Direction = "LeftToRight";
                }
                else if (StartingPoint.y == 90)
                {
                    Direction = "RightToLeft";
                }
            }
            else if (Direction == "Projectile")
            {
                StartingPoint.SetXY(StartingPoint.GetX() + 1, StartingPoint.GetY() - 1);
            }
            else if (Direction == "Diagonal")
            {
                if (StartingPoint.y != 90 || StartingPoint.y != 90)
                    StartingPoint.SetXY(StartingPoint.GetX() + 1, StartingPoint.GetY() + 1);
            }
        }
        public void Draw()
        {
            int x = 0, y = 0;
            for (int i = StartingPoint.x; i < StartingPoint.x + 5; i++)
            {
                for (int j = StartingPoint.y; j < StartingPoint.y + 3; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(Shape[x, y]);
                    y++;
                }
                x++;
                y = 0;
            }
        }



        public void Draw1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(j + StartingPoint.y, i + StartingPoint.x);
                    Console.Write(Shape[i, j]);
                }
            }
        }
    }
}
