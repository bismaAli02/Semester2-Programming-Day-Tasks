using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using EZInput;

namespace Framework1.Core
{
    public class GameObject
    {
        private PictureBox pb;
        private string direction;
        public GameObject(Image img, int top, int left, string direction)
        {
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Top = top;
            Pb.Left = left;
            Pb.Width = img.Width;
            Pb.Height = img.Height;
            Pb.BackColor = Color.Transparent;
            this.direction = direction;
        }

        public PictureBox Pb { get => pb; set => pb = value; }

        public void Update(int move, int height, int width)
        {

            if (direction == "Left" || direction == "Right")
            {
                MovePeriodically(move, height, width);
            }
            else if (direction == "Move")
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    MoveThroughKeyBoard(move, 0);
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    MoveThroughKeyBoard(move, 1);
                }
                else if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    MoveThroughKeyBoard(move, 2);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    MoveThroughKeyBoard(move, 3);
                }

            }
            else if (direction == "Gravity")
            {
                Fall(move);
            }
        }

        private void Fall(int gravity)
        {
            Pb.Top += gravity;
        }

        private void MoveThroughKeyBoard(int move, int dir)
        {
            if (dir == 0)
            {
                Pb.Left -= move;
            }
            else if (dir == 1)
            {
                Pb.Left += move;
            }
            else if (dir == 2)
            {
                Pb.Top -= move;
            }
            else if (dir == 3)
            {
                Pb.Top += move;
            }
        }

        public void MovePeriodically(int move, int height, int width)
        {
            if (direction == "Left")
            {
                Pb.Left -= move;
            }
            else
            {
                Pb.Left += move;
            }
            if (Pb.Left <= 0)
            {
                direction = "Right";
            }
            if (pb.Left + pb.Width >= width)
            {
                direction = "Left";
            }
        }
    }
}
