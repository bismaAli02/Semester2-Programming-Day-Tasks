using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Framework1.Core
{
    public class Game
    {
        private List<GameObject> gameObjects;
        private int gravity;
        public event EventHandler onAddingGameObject;
        public Game(int gravity)
        {
            GameObjects = new List<GameObject>();
            this.Gravity = gravity;
        }

        public List<GameObject> GameObjects { get => gameObjects; set => gameObjects = value; }
        public int Gravity { get => gravity; set => gravity = value; }

        public void AddGameObj(Image img, int top, int left, string direction)
        {
            GameObject gb = new GameObject(img, top, left, direction);
            GameObjects.Add(gb);
            onAddingGameObject?.Invoke(gb.Pb, EventArgs.Empty);
        }
        public void AddGameObj(GameObject gb)
        {
            GameObjects.Add(gb);
            onAddingGameObject?.Invoke(gb.Pb, EventArgs.Empty);
        }
        public void update(int height, int width)
        {
            foreach (GameObject gameObject in GameObjects)
            {
                gameObject.Update(Gravity, height, width);
            }
        }
    }
}
