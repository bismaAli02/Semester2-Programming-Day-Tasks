using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman.BL;
using System.Threading;

namespace Pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "maze.txt";
            Grid mazeGrid = new Grid(24, 71, path);
            pacman Player = new pacman(9, 32, mazeGrid);
            Ghost G1 = new Ghost(15, 39, 'H', "left", 0.1F, ' ', mazeGrid);
            Ghost G2 = new Ghost(20, 57, 'V', "up", 0.5F, ' ', mazeGrid);
            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(G1);
            enemies.Add(G2);
            mazeGrid.Draw();
            Player.Draw();
            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                Player.PrintScore();
                Player.Remove();
                Player.Move();
                Player.Draw();
                foreach (Ghost g in enemies)
                {
                    g.remove();
                    g.move();
                    g.draw();
                }
                if (mazeGrid.IsStoppingCondition())
                {
                    gameRunning = false;
                }
            }
        }
    }
}
