using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    [Serializable]
    /// <summary>
    /// Represents a customer with an identifier, name, address, and associated shopping cart.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the customer's address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the shopping cart identifier associated with the customer.
        /// </summary>
        public int ShoppingCartId { get; set; }
    }
}
