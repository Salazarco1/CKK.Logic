using CKK.DB.Interfaces;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Formats;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Repository
{
    /// <summary>
    /// Provides database operations for the Order entity.
    /// Implements the IOrderRepository interface.
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRepository"/> class.
        /// </summary>
        public OrderRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }

        /// <summary>
        /// Retrieves an order associated with a specific customer identifier.
        /// </summary>
        public Order GetOrderByCustomerId(int id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM Orders WHERE CustomerId = @Id";
                connection.Open();
                return connection.QuerySingleOrDefault<Order>(sql, new { Id = id });
            }
        }

        /// <summary>
        /// Retrieves an order by its unique identifier.
        /// </summary>
        Order IGenericRepository<Order>.GetById(int id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM Orders WHERE OrderId = @Id";
                connection.Open();
                return connection.QuerySingleOrDefault<Order>(sql, new { Id = id });
            }
        }

        /// <summary>
        /// Retrieves all orders from the database.
        /// </summary>
        public IEnumerable<Order> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM Orders";
                connection.Open();
                return connection.Query<Order>(sql);
            }
        }

        /// <summary>
        /// Adds a new order to the database.
        /// </summary>
        public int Add(Order entity)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "INSERT INTO Orders (OrderId, OrderNumber, CustomerId, ShoppingCartId) VALUES (@OrderId, @OrderNumber, @CustomerId, @ShoppingCartId)";
                connection.Open();
                return connection.Execute(sql, entity);
            }
        }

        /// <summary>
        /// Updates an existing order in the database.
        /// </summary>
        public void Update(Order entity)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "UPDATE Orders SET OrderNumber = @OrderNumber, ShoppingCartId = @ShoppingCartId, CustomerId = @CustomerId WHERE OrderId = @Id";
                connection.Execute(sql, new { entity.OrderNumber, entity.ShoppingCartId, entity.OrderId, entity.CustomerId });
            }
        }

        /// <summary>
        /// Deletes an order from the database by its unique identifier.
        /// </summary>
        public void Delete(int id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                string sql = "DELETE FROM Orders WHERE OrderId = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}
