using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {

        public ShoppingCartItem(Product product, int quantity) // constructor for the class
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal GetTotal() //calculates the total
        {
            decimal quantity = Quantity;
            decimal price = Product.Price;

            decimal total = quantity * price;

            return total;
        }

    }
}
