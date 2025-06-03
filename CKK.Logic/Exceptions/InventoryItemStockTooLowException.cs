using CKK.Logic;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    
    /// <summary>
    /// Represents an exception that is thrown when an inventory item's stock is too low.
    /// Inherits from the base Exception class.
    /// </summary>
    public class InventoryItemStockTooLowException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InventoryItemStockTooLowException class.
        /// </summary>
        public InventoryItemStockTooLowException() { }
    }
}
