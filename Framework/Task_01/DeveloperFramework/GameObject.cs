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
    public class GameObject
    {
        PictureBox pb;
        public GameObject(Image img,int left,int top)
        {
            pb = new PictureBox();
            pb.Image = img;
            pb.Left = left;
            pb.Top = top; 
            pb.Width = img.Width;
            pb.Height = img.Height;
            pb.BackColor = Color.Transparent;
        }

        internal PictureBox Pb { get => pb; set => pb = value; }
        public void update(int gravity)
        {
            pb.Top+=gravity;
        }
    }
}
