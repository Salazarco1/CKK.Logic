using CKK.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.UOW
{
    /// <summary>
    /// Provides a factory for creating and managing database connections.
    /// Implements IDisposable to ensure proper resource cleanup.
    /// </summary>
    public class DatabaseConnectionFactory : IConnectionFactory, IDisposable
    {
        private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = StructuredProjectDB";

        /// <summary>
        /// Retrieves the connection string from configuration settings.
        /// </summary>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Gets a database connection instance using the configured connection factory.
        /// </summary>
        public IDbConnection GetConnection
        {
            get
            {
                DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;

                return conn;
            }
        }

        /// <summary>
        /// Disposes of the database connection, ensuring proper resource cleanup.
        /// </summary>
        public void Dispose()
        {
            using (var conn = GetConnection)
            {
                conn.Dispose();
            }
        }
    }
}
