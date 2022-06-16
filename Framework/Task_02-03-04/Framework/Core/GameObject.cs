using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Framework.Movement;

namespace Framework.Core
{
    public class GameObject
    {
        private PictureBox pb;
        private IMovement movement;
        public GameObject(Image img, int left, int top,IMovement movement)
        {
            pb = new PictureBox();
            pb.Image = img;
            pb.Left = left;
            pb.Top = top;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.BackColor = Color.Transparent;
            this.movement = movement;
        }

        internal PictureBox Pb { get => pb; set => pb = value; }
        public void update(int gravity)
        {
           pb.Location=movement.move(pb.Location);
        }
    }
}
