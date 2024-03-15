using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public interface IShoppingCart
    {
        // creates the methods required for a class using this Interface
        int GetCustomerId();

        ShoppingCartItem GetProductById(int id); 

        ShoppingCartItem AddProduct(Product prod, int quantity); 

        ShoppingCartItem RemoveProduct(int id, int quantity);

        decimal GetTotal();

        List<ShoppingCartItem> GetProducts();
    }
}
