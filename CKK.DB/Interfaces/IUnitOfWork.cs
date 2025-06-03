using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    /// <summary>
    /// Defines a unit of work for managing multiple repository operations.
    /// Provides access to product, order, and shopping cart repositories.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the repository for product-related database operations.
        /// </summary>
        IProductRepository Products { get; }

        /// <summary>
        /// Gets the repository for order-related database operations.
        /// </summary>
        IOrderRepository Orders { get; }

        /// <summary>
        /// Gets the repository for shopping cart-related database operations.
        /// </summary>
        IShoppingCartRepository ShoppingCarts { get; }
    }
}
