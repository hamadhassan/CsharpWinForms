using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.BL;

namespace ShoppingCart.DL
{
    internal class ShoppingCartDL
    {
        private static List<ShoppingCartBL> shoppingCartsList=new List<ShoppingCartBL>();

        public static void setIntoShoppingList(ShoppingCartBL shoppingCart)
        {
            shoppingCartsList.Add(shoppingCart);
        }
        
        public static List<ShoppingCartBL> getShoppingList()
        {
            return shoppingCartsList;
        }
    }
}
