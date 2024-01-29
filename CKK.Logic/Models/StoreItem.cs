using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product _product;
        private int _quantity;

        public StoreItem(Product product, int quantity) // constructor for the class
        {
            _product = product;
            _quantity = quantity;
        }

        public int GetQuantity() // gets the quantity
        {
            return _quantity;
        }
        public void SetQuantity(int quantity) // sets the quantity
        {
            _quantity = quantity;
        }
        public Product GetProduct() // gets the product
        {
            return _product;
        }
        public void SetProduct(Product product) // sets the product
        {
            _product = product;
        }
    }
}
