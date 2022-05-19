using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.BL;

namespace Login.DL
{
    internal class CrediantialDL
    {
        public static List<Crediational> crediantialsList = new List<Crediational>();

        public static void setIntoListCrediantial(Crediational newUser)
        {
            crediantialsList.Add(newUser);
        }
        public static List<Crediational> getCrediationalList()
        {
            return crediantialsList;
        }
    }
}
