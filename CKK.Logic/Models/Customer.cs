using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _adress;

        public Customer(int id, string name, string address)
        {
            _id = id;
            _name = name;
            _adress = address;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id) 
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetAdress()
        {
            return _adress;
        }

        public void SetAdress(string adress)
        {
            _adress = adress;
        }
    }
}
