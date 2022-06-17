using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using System.Drawing;
using System.Windows.Forms;
using Framework.Movement;

namespace Framework.Core
{
    public class Game
    {
        int gravity;
        List<GameObject> gameObjectsList;
        public event EventHandler onGameObjectAdded;
        public Game(int gravity)
        {
            this.gravity = gravity;
            gameObjectsList = new List<GameObject>();
        }

        public EventHandler OnGameObjectAdded { get => onGameObjectAdded; set => onGameObjectAdded = value; }

        public void addGameObject(Image img, int left, int top,IMovement movement)
        {
            GameObject gameObject = new GameObject(img, left, top,movement);
            gameObjectsList.Add(gameObject);
            onGameObjectAdded?.Invoke(gameObject.Pb, EventArgs.Empty);
        }
        public void keyPressed(Keys keyCode)
        {
            foreach(GameObject go in gameObjectsList)
            {
                if (go.Movement.GetType() == typeof(Keyboard))
                {
                    Keyboard keyboardHandle = (Keyboard)go.Movement;
                    keyboardHandle.keyPressedByUser(keyCode);
                }
            }
        }
        public void update()
        {
            foreach (GameObject go in gameObjectsList)
            {
                go.update(this.gravity);
            }
        }
    }
}
