using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart (Customer cust) // constructor for the class
        {
            _customer = cust;
        }

        public int GetCustomerId() // gets customer ID
        {
            int id = _customer.GetId();
            
            return id;
        }

        public ShoppingCartItem GetProductById(int id) // returns product with matching ID
        {
            if(_product1.GetProduct().GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetProduct().GetId() == id)
            {
                return _product2;
            }
            else if (_product3.GetProduct().GetId() == id)
            {
                return _product3;
            }
            
            return null;
        }

        public ShoppingCartItem AddProduct(Product prod) //adds product to cart
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity) // adds quantity to cart
        {
            ShoppingCartItem product = new ShoppingCartItem(prod, quantity);

            if (quantity <= 0)
            {
                return null;
            }

            if (_product1 == null)
            {
                _product1 = product;
                return product;
            }
            else if (_product2 == null)
            {
                _product2 = product;
                return _product2;
            }
            else if (_product3 == null)
            {
                _product3 = product;
                return _product3;
            }

            if (prod.GetId() == _product1.GetProduct().GetId() && _product1 != null)
            {
               _product1.SetQuantity(_product1.GetQuantity() + quantity);
                return _product1;
            }
            else if (prod.GetId() == _product2.GetProduct().GetId() && _product2 != null)
            {
               _product2.SetQuantity(_product2.GetQuantity() + quantity);
                return _product2;
            }
            else if (prod.GetId() == _product3.GetProduct().GetId() && _product3 != null)
            {
               _product3.SetQuantity(_product3.GetQuantity() + quantity);
                return _product3;
            }

            return null;
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity) // removes quantity from cart
        {
            ShoppingCartItem product = new ShoppingCartItem(prod, quantity);

            if (quantity < 1)
            {
                return null;
            }

            if (_product1 == null)
            {
                _product1 = product;
                return product;
            }
            else if (_product2 == null)
            {
                _product2 = product;
                return _product2;
            }
            else if (_product3 == null)
            {
                _product3 = product;
                return _product3;
            }

            if (prod.GetId() == _product1.GetProduct().GetId() && _product1 != null)
            {
                _product1.SetQuantity(_product1.GetQuantity() - quantity);
                return _product1;
            }
            else if (prod.GetId() == _product2.GetProduct().GetId() && _product2 != null)
            {
                _product2.SetQuantity (_product2.GetQuantity() - quantity);
                return _product2;
            }
            else if (prod.GetId() == _product3.GetProduct().GetId() && _product3 != null)
            {
                _product3.SetQuantity (_product3.GetQuantity() - quantity);
                return _product3;
            }

            return null;
        }

        public decimal GetTotal() // calculates total
        {
            decimal total = _product1.GetTotal() + _product2.GetTotal() + _product3.GetTotal(); ;
            return total;
        }

        public ShoppingCartItem GetProduct(int prodNum) // returns the product in the postion of prodNum or null
        {
            if (prodNum == 1)
            {
                return _product1;
            }
            else if (prodNum == 2)
            {
                return _product2;
            }
            else if (prodNum == 3)
            {
                return _product3;
            }

            return null;
        }
    }
}
