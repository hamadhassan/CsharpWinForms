using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.BL
{
    internal class ShoppingCartBL
    {
        private string name;
        private float price;
        public ShoppingCartBL(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }

    }
}
