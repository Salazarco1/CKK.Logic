using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    /// <summary>
    /// Represents an order placed by a customer.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the order number, which may be used for tracking purposes.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier associated with the order.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the shopping cart identifier related to the order.
        /// </summary>
        public int ShoppingCartId { get; set; }
    }
}
