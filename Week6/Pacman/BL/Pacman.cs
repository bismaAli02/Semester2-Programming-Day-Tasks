using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.Threading;

namespace Pacman.BL
{
    class pacman
    {
        public pacman(int x, int y, Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.mazeGrid = mazeGrid;
        }
        private int x;
        private int y;
        private int score;
        private Grid mazeGrid;
        public void Draw()
        {
            Console.SetCursorPosition(y, x);
            Console.Write("P");
            Cell c = mazeGrid.GetCell(x, y);
            c.SetValue('P');
        }
        public void Remove()
        {
            Console.SetCursorPosition(y, x);
            Console.Write(" ");
        }
        public void PrintScore()
        {
            Console.SetCursorPosition(79, 12);
            Console.WriteLine("Score: " + score);
        }
        public void Move()
        {
            Cell c = mazeGrid.FindPacman();
            if (c != null)
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    MoveUp(c, mazeGrid.GetUpCell(c));
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    MoveDown(c, mazeGrid.GetDownCell(c));
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    MoveLeft(c, mazeGrid.GetLeftCell(c));
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    MoveRight(c, mazeGrid.GetRightCell(c));
                }
            }
        }
        private void IncreaseScore()
        {
            score++;
        }
        public void MoveLeft(Cell current, Cell next)
        {
            if (next.GetValue() == '.')
            {
                IncreaseScore();
            }
            if (next.GetValue() != '#' && next.GetValue() != '|' && next.GetValue() != '%')
            {
                current.SetValue(' ');
                next.SetValue('P');
                y--;
            }
        }
        public void MoveRight(Cell current, Cell next)
        {
            if (next.GetValue() == '.')
            {
                IncreaseScore();
            }
            if (next.GetValue() != '#' && next.GetValue() != '|' && next.GetValue() != '%')
            {
                current.SetValue(' ');
                next.SetValue('P');
                y++;
            }
        }
        public void MoveUp(Cell current, Cell next)
        {
            if (next.GetValue() == '.')
            {
                IncreaseScore();
            }
            if (next.GetValue() != '#' && next.GetValue() != '|' && next.GetValue() != '%')
            {
                current.SetValue(' ');
                next.SetValue('P');
                x--;
            }
        }
        public void MoveDown(Cell current, Cell next)
        {
            if (next.GetValue() == '.')
            {
                IncreaseScore();
            }
            if (next.GetValue() != '#' && next.GetValue() != '|' && next.GetValue() != '%')
            {
                current.SetValue(' ');
                next.SetValue('P');
                x++;
            }
        }
    }
}