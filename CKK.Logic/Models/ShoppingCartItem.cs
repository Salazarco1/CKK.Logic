using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _prodcut;
        private int _quantity;

        public ShoppingCartItem(Product product, int quantity) 
        {
            _prodcut = product;
            _quantity = quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public Product GetProduct()
        {
            return _prodcut;
        }
        public void SetProduct(Product product)
        {
            _prodcut = product;
        }
    }
}
