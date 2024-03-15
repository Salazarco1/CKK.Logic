using CKK.Logic;
using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InvalidIdException : Exception
    {
        private string NewMessage = "Id is less than 0.";
        public InvalidIdException()
        {
            throw new Exception(NewMessage);
        }
    }
}
