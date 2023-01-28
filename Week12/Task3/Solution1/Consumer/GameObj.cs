using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework1.Core;
using System.Windows.Forms;
using System.Drawing;

namespace Consumer
{
    public class GameObj : GameObject
    {
        private int times = 0;
        public GameObj(Image img, int top, int left, string direction) : base(img, top, left, direction)
        {

        }
        public override void Update(int move, int height, int width)
        {
            if (direction == "Diagonal")
            {
                pb.Left += move;
                pb.Top += move;
            }
            if (direction == "ZigZag1")
            {
                pb.Left += move;
                pb.Top += move;
                times++;
                if (times == 15)
                {
                    direction = "ZigZag2";
                    times = 0;
                }
            }
            else if (direction == "ZigZag2")
            {
                pb.Left += move;
                pb.Top -= move;
                times++;
                if (times == 15)
                {
                    direction = "ZigZag1";
                    times = 0;
                }
            }
        }
    }
}
