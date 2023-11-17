using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;

        public Product(Product product, string name, double price) 
        {
            _id = product._id;
            _name = name;
            _price = price;
        }
    }
}
