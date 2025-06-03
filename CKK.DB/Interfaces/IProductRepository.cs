using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    /// <summary>
    /// Defines database operations specific to the Product entity.
    /// Inherits generic repository functionality from IGenericRepository.
    /// </summary>
    public interface IProductRepository : IGenericRepository<Product>
    {
        /// <summary>
        /// Retrieves a list of products that match the specified name.
        /// </summary>
        List<Product> GetByName(string name);
    }
}
