using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    /// <summary>
    /// Represents an inventory item that contains product details and quantity management.
    /// </summary>
    public abstract class InventoryItem
    {
        /// <summary>
        /// Gets or sets the associated product of the inventory item.
        /// </summary>
        public Product Product { get; set; }

        private int quantity;

        /// <summary>
        /// Gets or sets the quantity of the inventory item.
        /// Ensures that quantity is non-negative, throwing an exception if below zero.
        /// </summary>
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity >= 0)
                {
                    quantity = value;
                }
                if (quantity < 0)
                {
                    throw new InventoryItemStockTooLowException();
                }
            }
        }
    }
}
