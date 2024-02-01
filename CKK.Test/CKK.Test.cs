using CKK.Logic.Models;
using Xunit;
using Xunit.Sdk;

namespace CKK.Logic.Tests
{
    public class CKKTest
    {
        [Fact]
        public void AddProduct_ShouldAddProductCorrectly()
        {
            try
            {
                Customer customer = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(customer);
                Product prod = new Product();
                int quantity = 3;

                ShoppingCartItem product = new ShoppingCartItem(prod, quantity);

                int expectedQuantity = 3;

                shoppingCart.AddProduct(prod, expectedQuantity);
                int actualQuantity = product.GetQuantity();

                Assert.Equal(actualQuantity, expectedQuantity);

            }
            catch
            {
                throw new XunitException("The product was not added correctly");
            }
        }

        [Fact]
        public void RemoveProduct_ShouldRemoveProductCorretly()
        {
            try
            {
                Customer customer = new Customer();
                ShoppingCart shoppingCart = new ShoppingCart(customer);
                Product prod = new Product();
                int quantity = 3;

                ShoppingCartItem product = new ShoppingCartItem(prod, quantity);

                int expectedQuantity = 3;

                shoppingCart.RemoveProduct(prod, expectedQuantity);
                int actualQuantity = product.GetQuantity();

                Assert.Equal(actualQuantity, expectedQuantity);
            }
            catch
            {
                throw new XunitException("The product was not removed correctly");
            }
        }

        [Fact]
        public void GettingTotal_ShouldGetTheCorrectTotal()
        {
            try
            {
                Customer cust = new Customer();
                ShoppingCart ShoppingCart = new ShoppingCart(cust);
                
                Product prod1 = new Product();
                Product prod2 = new Product();
                Product prod3 = new Product();

                prod1.SetPrice(30.0m);
                prod2.SetPrice(0.0m);
                prod3.SetPrice(0.0m);
                int quantity = 1;
                ShoppingCartItem Item = new ShoppingCartItem(prod1, quantity);

                ShoppingCart.AddProduct(prod1, quantity);
                ShoppingCart.AddProduct(prod2, quantity);
                ShoppingCart.AddProduct(prod3, quantity);

                decimal expectedTotal = Item.GetTotal();

                
                decimal actualTotal = ShoppingCart.GetTotal();

                Assert.Equal(actualTotal, expectedTotal);
            }
            catch
            {
                throw new XunitException("The total is incorrect");
            }
        }
    }
}