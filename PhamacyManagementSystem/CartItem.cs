using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamacyManagementSystem
{
    internal class CartItem
    {
        public String name;
        public double price;
        public int quantity;

        public CartItem(String name, double price, int quantity)
        {
            this.name = name; 
            this.price = price; 
            this.quantity = quantity;
        }
    }
}
