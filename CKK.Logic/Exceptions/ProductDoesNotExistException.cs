using CKK.Logic;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    
    /// <summary>
    /// Represents an exception that is thrown when a requested product does not exist.
    /// Inherits from the base Exception class.
    /// </summary>
    public class ProductDoesNotExistException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the ProductDoesNotExistException class.
        /// </summary>
        public ProductDoesNotExistException() { }
    }
}
