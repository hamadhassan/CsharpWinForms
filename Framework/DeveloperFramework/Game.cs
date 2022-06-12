using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DeveloperFramework
{
    public class Game
    {
        int gravity = 10;
        List<GameObject> gameObjectsList;
        EventHandler onGameObjectAdded;
        public Game(int gravity)
        {
            this.gravity = gravity;
            gameObjectsList =new  List<GameObject>();
        }

        public EventHandler OnGameObjectAdded { get => onGameObjectAdded; set => onGameObjectAdded = value; }

        public void addGameObject(Image img,int left,int top)
        {
            GameObject gameObject = new GameObject(img, left, top);
            gameObjectsList.Add(gameObject);
            onGameObjectAdded?.Invoke(gameObject, EventArgs.Empty);
        }
        public void update()
        {
            foreach(GameObject go in gameObjectsList)
            {
                go.update(this.gravity);
            }
        }
    }
}
