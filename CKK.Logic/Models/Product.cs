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
        private decimal _price;

        public int GetId() // gets ID
        {
            return _id;
        }
        public void SetId(int id) // sets ID
        {
            _id=id;
        }
        public string GetName() // gets name
        {
            return _name;
        }
        public void SetName(string name) // sets name
        {
            _name = name;
        }
        public decimal GetPrice() // gets proce
        {
            return _price;
        }
        public void SetPrice(decimal price) // sets price
        {
            _price = price;
        }
    }
}
