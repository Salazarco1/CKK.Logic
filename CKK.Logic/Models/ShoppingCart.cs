
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
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
    public class ShoppingCart : IShoppingCart
    {
        private Customer _customer;

        public List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>(); //creates the List

        public ShoppingCart(Customer cust) // constructor for the class
        {
            _customer = cust;
        }

        public Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
            }
        }

        public Product Products
        {
            get
            {
                return Products;
            }
            set
            {
                Products = value;
            }
        }

        public int GetCustomerId() // gets customer ID
        {
            int id = Customer.Id;

            return id;
        }

        public ShoppingCartItem GetProductById(int id) // returns product with matching ID
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            else
            {
                var getProductById =
                    from item in shoppingCartItems
                    where item.Product.Id == id
                    select item;

                if (getProductById.Any())
                {
                    return getProductById.FirstOrDefault();
                }
            }
            
            return null;

        }

        public ShoppingCartItem AddProduct(Product prod, int quantity) // adds quantity to cart
        {
            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            for (int i = 0; i < shoppingCartItems.Count; i++)
            {

                if (shoppingCartItems[i].Product.Id == prod.Id)
                {
                    shoppingCartItems[i].Quantity = shoppingCartItems[i].Quantity + quantity;
                    return shoppingCartItems[i];
                }

            }
            var item = new ShoppingCartItem(prod, quantity);
            shoppingCartItems.Add(item);
            return item;
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity) // removes quantity from cart
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var temp = GetProductById(id);
            
            if(temp == null)
            {
                throw new ProductDoesNotExistException();
            }
                
            for (int i = 0; i < shoppingCartItems.Count; i++)
            {
                if (shoppingCartItems[i].Product.Id == GetProductById(id).Product.Id)
                {
                    shoppingCartItems[i].Quantity = shoppingCartItems[i].Quantity - quantity;
                    if (shoppingCartItems[i].Quantity < 0)
                    {
                        shoppingCartItems[i].Quantity = 0;
                    }
                    return shoppingCartItems[i];
                }
            }

            return null;
        }

        public decimal GetTotal() // calculates total 
        {
            decimal total = 0;
            if (shoppingCartItems != null)
            {
                foreach (var item in shoppingCartItems)
                {
                    total += item.GetTotal();
                }
                return total;
            }

            return 0;
        }

        public List<ShoppingCartItem> GetProducts() // returns the product in the postion of prodNum or null
        {
            return shoppingCartItems;
        }
    }
}
