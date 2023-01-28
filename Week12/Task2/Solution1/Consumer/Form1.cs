using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework1.Core;
using Consumer.Properties;

namespace Consumer
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(4);
            game.onAddingGameObject += new EventHandler(addIntoControls);
            game.AddGameObj(Resources.Plate, 20, 100);
        }

        private void addIntoControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.update(this.Height, this.Width);
        }
    }
}
