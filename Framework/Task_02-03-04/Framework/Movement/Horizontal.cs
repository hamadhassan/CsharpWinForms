using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Framework.Movement
{
    public class Horizontal:IMovement
    {
        private int speed;
        private Point boundary;
        private string direction;
        private int offset;
        public Horizontal(int speed,Point boundary,string direction)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            offset = 200;
        }
        public Point move(Point location)
        {
            if (location.X <= 0)
            {
                direction = "right";
            }
            else if(location.X + offset >= boundary.X) 
            {
                direction = "left";
            }
            if (direction == "left")
            {
                location.X -= speed;
            }
            if (direction == "right")
            {
                location.X += speed;

            }
            return location;
        }

    }
}
