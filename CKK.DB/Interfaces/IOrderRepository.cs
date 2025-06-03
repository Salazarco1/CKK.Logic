using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    /// <summary>
    /// Defines database operations specific to orders.
    /// Inherits generic CRUD functionality from IGenericRepository.
    /// </summary>
    public interface IOrderRepository : IGenericRepository<Order>
    {
        /// <summary>
        /// Retrieves an order associated with a specific customer identifier.
        /// </summary>
        Order GetOrderByCustomerId(int id);
    }
}
