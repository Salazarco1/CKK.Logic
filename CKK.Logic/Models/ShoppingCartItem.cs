using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    [Serializable]

    /// <summary>
    /// Represents an item in a shopping cart.
    /// Inherits from InventoryItem.
    /// </summary>
    public class ShoppingCartItem : InventoryItem
    {
        /// <summary>
        /// Gets or sets the associated product in the shopping cart.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the shopping cart identifier.
        /// </summary>
        public int ShoppingCartId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier associated with the shopping cart item.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        public int ProductId { get; set; }

        private int quantity;

        /// <summary>
        /// Gets or sets the quantity of the product in the shopping cart.
        /// Ensures that quantity is non-negative, throwing an exception if below zero.
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0) { quantity = value; }
                else { throw new InventoryItemStockTooLowException(); }
            }
        }

        /// <summary>
        /// Calculates the total price of the shopping cart item.
        /// </summary>
        public decimal GetTotal()
        {
            return Product.Price * Quantity;
        }
    }
}
