using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    /// <summary>
    /// Defines generic CRUD operations for entities.
    /// Supports retrieval, addition, updating, and deletion.
    /// </summary>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Retrieves an entity by its unique identifier.
        /// </summary>
        TEntity GetById(int id);

        /// <summary>
        /// Retrieves all entities from the database.
        /// </summary>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Adds a new entity to the database.
        /// </summary>
        int Add(TEntity entity);

        /// <summary>
        /// Updates an existing entity in the database.
        /// </summary>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes an entity by its unique identifier.
        /// </summary>
        void Delete(int id);
    }
}
