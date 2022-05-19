using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorChanging.BL;

namespace ColorChanging.BL
{
    internal class ChangeColor
    {
        private string color;
        public ChangeColor()
        {
            color = "white";
        }
        public ChangeColor(string color)
        {
            this.color = color;
        }
        public string Color { get => color; set => color = value; }
        public string getNextColor(string color, List<string> colorList)
        {
            string nextColor = "";
            for (int i = 0; i < colorList.Count; i++)
            {
                if (color == colorList[i])
                {
                    if(colorList.Count == 3)
                    {
                        nextColor = colorList[0];
                    }
                    if (colorList.Count < 3)
                    {
                        nextColor = colorList[i+1];
                    }
                }
               
            }
            return nextColor;
        }
        public string getPreviousColor(string color, List<string> colorList)
        {
            string nextColor = "";
            for (int i = 0; i < colorList.Count; i++)
            {
                if (color == colorList[i])
                {
                    if (colorList.Count == 0)
                    {
                        nextColor = colorList[3];
                    }
                    if (colorList.Count > 0)
                    {
                        nextColor = colorList[i - 1];
                    }
                }

            }
            return nextColor;
        }
    }
}
