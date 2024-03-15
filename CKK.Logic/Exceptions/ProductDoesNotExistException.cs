using CKK.Logic;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class ProductDoesNotExistException : Exception
    {
        private string NewMessage = "Product or Item Does Not Exist.";

        public ProductDoesNotExistException()
        {
            throw new Exception(NewMessage);
        }
    }
}
