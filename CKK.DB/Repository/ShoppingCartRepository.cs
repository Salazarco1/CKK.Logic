using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Repository
{
    /// <summary>
    /// Provides database operations for managing shopping carts and their items.
    /// Implements the IShoppingCartRepository interface.
    /// </summary>
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartRepository"/> class.
        /// </summary>
        public ShoppingCartRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }

        /// <summary>
        /// Adds a new shopping cart item to the database.
        /// </summary>
        public int Add(ShoppingCartItem entity)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "INSERT INTO ShoppingCartItems (ShoppingCartId, ProductId, Quantity) VALUES (@ShoppingCartId, @ProductId, @Quantity)";
                connection.Open();
                return connection.Execute(sql, entity);
            }
        }

        /// <summary>
        /// Adds a product to the shopping cart, updating quantity if it already exists.
        /// </summary>
        public ShoppingCartItem AddToCart(int shoppingCartId, int productId, int quantity)
        {
            using (var conn = _connectionFactory.GetConnection)
            {
                ProductRepository _productRepository = new ProductRepository(_connectionFactory);
                var item = _productRepository.GetById(productId);
                var productItems = GetProducts(shoppingCartId).Find(x => x.ProductId == productId);

                var shopItem = new ShoppingCartItem()
                {
                    ShoppingCartId = shoppingCartId,
                    ProductId = productId,
                    Quantity = quantity
                };

                if (item.Quantity >= quantity)
                {
                    if (productItems != null) Update(shopItem);
                    else Add(shopItem);
                }
                return shopItem;
            }
        }

        /// <summary>
        /// Clears all items from the shopping cart.
        /// </summary>
        public int ClearCart(int shoppingCartId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                string sql = "DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @Id";
                return connection.Execute(sql, new { Id = shoppingCartId });
            }
        }

        /// <summary>
        /// Retrieves all products in the shopping cart.
        /// </summary>
        public List<ShoppingCartItem> GetProducts(int shoppingCartId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM ShoppingCartItems WHERE ShoppingCartId = @Id";
                connection.Open();
                return connection.Query<ShoppingCartItem>(sql, new { Id = shoppingCartId }).ToList();
            }
        }

        /// <summary>
        /// Calculates the total cost of all items in the shopping cart.
        /// </summary>
        public decimal GetTotal(int shoppingCartId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var items = SqlMapper.Query<ShoppingCartItem>(connection, @"SELECT * FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId", new { ShoppingCartId = shoppingCartId }).ToList();
                List<decimal> total = new List<decimal>();
                ProductRepository _productRepository = new ProductRepository(_connectionFactory);

                foreach (var item in items)
                {
                    var product = _productRepository.GetById(item.ProductId);
                    total.Add(product.Price * (decimal)item.Quantity);
                }
                return total.Sum();
            }
        }

        /// <summary>
        /// Marks the shopping cart as ordered, removing items after checkout.
        /// </summary>
        public void Ordered(int shoppingCartId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                SqlMapper.Execute(connection, "DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId", new { ShoppingCartId = shoppingCartId });
            }
        }

        /// <summary>
        /// Updates an existing shopping cart item.
        /// </summary>
        public int Update(ShoppingCartItem entity)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "UPDATE ShoppingCartItems SET Quantity = @Quantity WHERE ShoppingCartId = @ShoppingCartId AND ProductId = @ProductId";
                connection.Open();
                return connection.Execute(sql, entity);
            }
        }
    }
}
