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
    /// Represents an exception that is thrown when an invalid ID is encountered.
    /// Inherits from the base Exception class.
    /// </summary>
    public class InvalidIdException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InvalidIdException class.
        /// </summary>
        public InvalidIdException() { }
    }
}
