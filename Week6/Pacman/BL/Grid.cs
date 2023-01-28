using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EZInput;

namespace Pacman.BL
{
    class Grid
    {
        public Grid(int rowSize, int colSize, string path)
        {
            this.rowSize = rowSize;
            this.colSize = colSize;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                int j = 0;
                while ((record = f.ReadLine()) != null)
                {
                    for (int i = 0; i < record.Length; i++)
                    {
                        char value = record[i];
                        Cell c = new Cell(value, j, i);
                        //maze[j, i].SetValue(value);
                        //maze[j, i].SetXY(j, i);
                        maze[j, i] = c;
                    }
                    j++;
                }
                f.Close();
            }
        }
        private Cell[,] maze = new Cell[24, 71];
        private int rowSize;
        private int colSize;
        public Cell GetCell(int x, int y)
        {
            return maze[x, y];
        }
        public Cell GetLeftCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.GetX() == maze[i, j].GetX() && c.GetY() == maze[i, j].GetY())
                    {
                        return maze[i, j - 1];
                    }
                }
            }
            return null;
        }
        public Cell GetRightCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.GetX() == maze[i, j].GetX() && c.GetY() == maze[i, j].GetY())
                    {
                        return maze[i, j + 1];
                    }
                }
            }
            return null;
        }
        public Cell GetUpCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.GetX() == maze[i, j].GetX() && c.GetY() == maze[i, j].GetY())
                    {
                        return maze[i - 1, j];
                    }
                }
            }
            return null;
        }
        public Cell GetDownCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.GetX() == maze[i, j].GetX() && c.GetY() == maze[i, j].GetY())
                    {
                        return maze[i + 1, j];
                    }
                }
            }
            return null;
        }
        public Cell FindGhost(char ghostChar)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (maze[i, j].IsGhostPresent(ghostChar))
                    {
                        return maze[i, j];
                    }
                }
            }
            return null;
        }
        public Cell FindPacman()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (maze[i, j].IsPacmanPresent())
                    {
                        return maze[i, j];
                    }
                }
            }
            return null;
        }
        public void Draw()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    Console.SetCursorPosition(maze[i, j].GetY(), maze[i, j].GetX());
                    Console.Write(maze[i, j].GetValue());
                }
            }
        }
        public bool IsStoppingCondition()
        {
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                return true;
            }
            return false;
        }
    }
}
