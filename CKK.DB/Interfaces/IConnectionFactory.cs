using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    /// <summary>
    /// Provides a factory for creating and managing database connections.
    /// Implements IDisposable to allow proper resource cleanup.
    /// </summary>
    public interface IConnectionFactory : IDisposable
    {
        /// <summary>
        /// Gets a database connection instance.
        /// </summary>
        IDbConnection GetConnection { get; }
    }
}
