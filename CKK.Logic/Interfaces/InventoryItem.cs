using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    [Serializable]
    public abstract class InventoryItem
    {
        public Product Product {  get; set; }
        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if(quantity >= 0)
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
