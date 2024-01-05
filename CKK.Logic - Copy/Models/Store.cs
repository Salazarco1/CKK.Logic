using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class Store
    {
        private int _id;
        private string _name;

        public Product _product1;
        public Product _product2;
        public Product _product3;

        public void SetId(int id)
        {
            _id = id;
        }
        public int GetId()
        {
            return _id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public Store AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                _product1 = prod;
            }
            else if (_product2 == null)
            {
                _product2 = prod;
            }
            else if (_product3 == null)
            {
                _product3 = prod;
            }
            return this;

        }
        public Store RemoveStoreItem(int productNumber)
        {
            if (productNumber == _product1.GetId())
            {
                _product1 = null;
            }
            else if (productNumber == _product2.GetId())
            {
                _product2 = null;
            }
            else if (productNumber == _product3.GetId())
            {
                _product3 = null;
            }

            return this;
        }
        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                return _product1;
            }
            else if (productNumber == 2)
            {
                return _product2;
            }
            else if (productNumber == 3)
            {
                return _product3;
            }
            else if (productNumber != 1 || productNumber != 2 || productNumber != 3)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
        public Product FindStoreItemByID(int id)
        {
            if (id == _product1.GetId())
            {
                return _product1;
            }
            else if (id == _product2.GetId())
            {
                return _product2;
            }
            else if (id == _product3.GetId())
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }
    }
}
