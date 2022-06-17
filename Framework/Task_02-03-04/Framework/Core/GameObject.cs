using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Framework.Movement;
using Framework.Collision;

namespace Framework.Core
{
    public class GameObject
    {
        private PictureBox pb;
        private IMovement movement;
        private ObjectType otype;//object type
        public GameObject(ObjectType otype,Image img, int left, int top,IMovement movement)
        {
            this.otype = otype;
            pb = new PictureBox();
            pb.Image = img;
            pb.Left = left;
            pb.Top = top;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.BackColor = Color.Transparent;
            this.movement = movement;
        }

        public IMovement Movement { get => movement; set => movement = value; }
        public ObjectType Otype { get => otype; set => otype = value; }
        internal PictureBox Pb { get => pb; set => pb = value; }
        public void updateLocation(int gravity)
        {
           pb.Location=movement.move(pb.Location);
        }
    }
}
