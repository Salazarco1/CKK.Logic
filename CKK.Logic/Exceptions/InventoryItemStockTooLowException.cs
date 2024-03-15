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
    public class InventoryItemStockTooLowException : Exception
    {
        private string NewMessage = "Product Quantity MUST be greater than 0.";

        public InventoryItemStockTooLowException() 
        {
            throw new Exception(NewMessage);
        }
    }
}
