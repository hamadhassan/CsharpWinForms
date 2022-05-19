using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorChanging.BL;

namespace ColorChanging.DL
{
    internal class ChangeColorDL
    {
        private static List<string> changeColorsList = new List<string>();
        public static void setIntoChangeColorList(string color)
        {
            changeColorsList.Add(color);

        }
        public static List<string> getChangeColorList()
        {
            return changeColorsList;
        }
    }
}
