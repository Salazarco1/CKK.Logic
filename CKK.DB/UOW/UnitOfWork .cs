using CKK.DB.Interfaces;
using CKK.DB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.UOW
{
    /// <summary>
    /// Implements the Unit of Work pattern to coordinate multiple repository instances.
    /// Provides a single point of access to product, order, and shopping cart repositories.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        public UnitOfWork(IConnectionFactory Conn)
        {
            Products = new ProductRepository(Conn);
            Orders = new OrderRepository(Conn);
            ShoppingCarts = new ShoppingCartRepository(Conn);
        }

        /// <summary>
        /// Gets the repository for product-related database operations.
        /// </summary>
        public IProductRepository Products { get; private set; }

        /// <summary>
        /// Gets the repository for order-related database operations.
        /// </summary>
        public IOrderRepository Orders { get; private set; }

        /// <summary>
        /// Gets or sets the repository for shopping cart-related database operations.
        /// </summary>
        public IShoppingCartRepository ShoppingCarts { get; set; }
    }
}
