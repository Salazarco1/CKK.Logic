using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    /// <summary>
    /// Defines operations for managing shopping carts and their contents.
    /// </summary>
    public interface IShoppingCartRepository
    {
        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        ShoppingCartItem AddToCart(int shoppingCartId, int productId, int quantity);

        /// <summary>
        /// Clears all items from the shopping cart.
        /// </summary>
        int ClearCart(int shoppingCartId);

        /// <summary>
        /// Calculates the total cost of all items in the shopping cart.
        /// </summary>
        decimal GetTotal(int shoppingCartId);

        /// <summary>
        /// Retrieves all products in the shopping cart.
        /// </summary>
        List<ShoppingCartItem> GetProducts(int shoppingCartId);

        /// <summary>
        /// Marks the shopping cart as ordered, finalizing the transaction.
        /// </summary>
        void Ordered(int shoppingCartId);

        /// <summary>
        /// Updates an existing shopping cart item.
        /// </summary>
        int Update(ShoppingCartItem entity);

        /// <summary>
        /// Adds a new shopping cart item to the database.
        /// </summary>
        int Add(ShoppingCartItem entity);
    }
}
