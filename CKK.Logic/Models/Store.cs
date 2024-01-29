using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;

        private Product _product1;
        private Product _product2;
        private Product _product3;

        public void SetId(int id) // sets the ID
        {
            _id = id;
        }
        public int GetId() // gets the ID
        {
            return _id;
        }
        public void SetName(string name) // sets name
        {
            _name = name;
        }
        public string GetName() // gets name
        {
            return _name;
        }

        public Product AddStoreItem(Product prod) // adds store item
        {
            if (_product1 == null)
            {
                _product1 = prod;
                return _product1;
            }
            else if (_product2 == null)
            {
                _product2 = prod;
                return _product3;
            }
            else if (_product3 == null)
            {
                _product3 = prod;
                return _product3;
            }
            else
            {
                return null;
            }
        }
        public Product RemoveStoreItem(int productNumber) // removes store item
        {
            if (productNumber == 1)
            {
                _product1 = null;
                return _product1;
            }
            else if (productNumber == 2)
            {
                _product2 = null;
                return _product2;
            }
            else if (productNumber == 3)
            {
                _product3 = null;
                return _product3;
            }
            else
            {
                return null;
            }
        }
        public Product GetStoreItem(int productNumber) // gets store item
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
        public Product FindStoreItemById(int id) // finds store item by ID
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
