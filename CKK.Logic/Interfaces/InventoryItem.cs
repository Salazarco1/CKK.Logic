using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        private Product product {  get; set; }
        private int quantity { get; set; }

        public Product Product
        {
            get 
            { 
                return product; 
            }
            set
            {
                if (product != null)
                {
                    product = value;
                }
            }

        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if(quantity > 0)
                {
                    quantity = value;
                }
                else if (quantity < 0)
                {
                    throw new InventoryItemStockTooLowException();
                }
            }
        }
    }
}
