using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Movement;
using System.Drawing;
using System.Windows.Forms;

namespace Framework.Movement
{
    public class Keyboard:IMovement
    {
        private int speed;
        private Point boundary;
        private int offset;
        private string ArrowAction=null;
        public Keyboard(int speed, Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
            offset = 200;
        }
        public void keyPressedByUser(Keys keyCode)
        {
            if (keyCode == Keys.Up)
            {
                ArrowAction = "up";
            }
            else if (keyCode == Keys.Down)
            {
                ArrowAction = "down";
            }
            else if (keyCode == Keys.Left)
            {
                ArrowAction = "left";
            }
            else if (keyCode == Keys.Right)
            {
                ArrowAction = "right";
            }
        }
        public Point move(Point location)
        {
            if (ArrowAction != null)
            {
                if (ArrowAction == "up")
                {
                    location.Y -= speed;
                }
                if (ArrowAction == "down")
                {
                    location.Y += speed;
                }
                if (ArrowAction == "left")
                {
                    location.X -= speed;
                }
                if (ArrowAction == "right")
                {
                    location.X += speed;
                }
            }
            ArrowAction = null;
            return location;
        }
    }
}
