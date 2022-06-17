using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using System.Drawing;
using System.Windows.Forms;
using Framework.Movement;
using Framework.Collision;

namespace Framework.Core
{
    public class Game:IGame
    {
        int gravity;
        List<GameObject> gameObjectsList;
        List<CollisionClass> collisionList;
        public event EventHandler OnGameObjectAdded;
        public event EventHandler OnPlayerDie;

        public Game(int gravity)
        {
            gameObjectsList = new List<GameObject>();
            collisionList = new List<CollisionClass>();
            this.gravity = gravity;
        }
        public void risePlayerDieEvent(PictureBox playerGameObject)
        {
            OnPlayerDie?.Invoke(playerGameObject, EventArgs.Empty);
        }
        public void addGameObject(ObjectType otype,Image img, int left, int top,IMovement movement)
        {
            GameObject gameObject = new GameObject(otype,img, left, top,movement);
            gameObjectsList.Add(gameObject);
            OnGameObjectAdded?.Invoke(gameObject.Pb, EventArgs.Empty);
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
            detectCollsion();
            foreach (GameObject go in gameObjectsList)
            {
                go.updateLocation(this.gravity);
            }
        }
        private void detectCollsion()
        {
            for(int x = 0; x < gameObjectsList.Count; x++)
            {
                for(int y = 0; y < gameObjectsList.Count; y++)
                {
                    if (gameObjectsList[x].Pb.Bounds.IntersectsWith(gameObjectsList[y].Pb.Bounds))
                    {
                        foreach(CollisionClass c in collisionList)
                        {
                            if (gameObjectsList[x].Otype == c.G1 && gameObjectsList[y].Otype == c.G2)
                            {
                                c.Behaviour.perfromAction(this, gameObjectsList[x], gameObjectsList[y]);
                            }
                        }
                    }
                }
            }
        }
        public void addCollsionIntoList(CollisionClass c)
        {
            collisionList.Add(c);
        }
    }
}
