using CKK.DB.Interfaces;
using CKK.Logic.Interfaces;
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
    /// Provides database operations for the Product entity.
    /// Implements the IProductRepository interface.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        public ProductRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }

        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        public int Add(Product entity)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "INSERT INTO Products (Price, Quantity, Name) VALUES (@Price, @Quantity, @Name)";
                connection.Open();
                return connection.Execute(sql, entity);
            }
        }

        /// <summary>
        /// Deletes a product from the database by its unique identifier.
        /// </summary>
        public void Delete(int id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                string sql = "DELETE FROM Products WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        public IEnumerable<Product> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM Products";
                connection.Open();
                return connection.Query<Product>(sql);
            }
        }

        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        public Product GetById(int id)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM Products WHERE Id = @Id";
                connection.Open();
                return connection.QuerySingleOrDefault<Product>(sql, new { Id = id });
            }
        }

        /// <summary>
        /// Retrieves a list of products that match the specified name using a LIKE query.
        /// </summary>
        public List<Product> GetByName(string name)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "SELECT * FROM Products WHERE Name LIKE @Name";
                connection.Open();
                return connection.Query<Product>(sql, new { Name = name }).ToList();
            }
        }

        /// <summary>
        /// Updates an existing product in the database.
        /// </summary>
        public void Update(Product entity)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var sql = "UPDATE Products SET Price = @Price, Quantity = @Quantity, Name = @Name WHERE Id = @Id";
                connection.Execute(sql, new { entity.Price, entity.Quantity, entity.Name, entity.Id });
            }
        }
    }
}
