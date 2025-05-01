using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    { 

        public List<StoreItem> Items = new List<StoreItem>(); // creates the List

        public StoreItem AddStoreItem(Product prod, int quantity) // adds store item
        {
            if (quantity < 0) { throw new InventoryItemStockTooLowException(); }

            for (int i = 0; i < Items.Count; i++)
            {

                if (Items[i].Product.Id == prod.Id)
                {
                    Items[i].Quantity = Items[i].Quantity + quantity;
                    return Items[i];
                }

            }

            while(prod.Id == 0)
            {
                Random randomId = new Random();

                prod.Id = randomId.Next(100, 500);

                var preExistingItem = FindStoreItemById(prod.Id);

                if (preExistingItem == null) { prod.Id = prod.Id; }
                else if (preExistingItem.Product.Id == prod.Id) { prod.Id = 0; }

            }

            var item = new StoreItem(prod, quantity);
            Items.Add(item);
            return item;
        }
        public StoreItem RemoveStoreItem(int id, int quantity) // removes store item
        {
            if (quantity < 0) { throw new ArgumentOutOfRangeException(); }

            var temp = FindStoreItemById(id);

            if (temp == null || Items.Count == 0) { throw new ProductDoesNotExistException(); }

            if(temp!= null || Items.Count > 0)
            {
                if (temp.Quantity - quantity <= 0)
                {
                    temp.Quantity = 0;
                    return temp;
                }
                else
                {
                    temp.Quantity = temp.Quantity - quantity;
                    return temp;
                }
            }

            return null;
        }

        public void DeleteStoreItem(int id) // deletes store item
        {
            if(id < 0) { throw new InvalidIdException(); }

            var temp = FindStoreItemById(id);

            if(temp == null || Items.Count == 0 || Items == null) { throw new ProductDoesNotExistException(); }
            else if(temp != null || Items.Count > 0 || Items != null) { Items.Remove(temp); }
        }

        public List<StoreItem> GetStoreItems() // gets store item
        {
            return Items;
        }

        public StoreItem FindStoreItemById(int id) // finds store item by ID
        {
            if(id < 0) { throw new InvalidIdException(); }

            if (id > 0)
            {
                var matchingId =
                   from item in Items
                   where item.Product.Id == id
                   select item;

                if (matchingId.Any()) { return matchingId.FirstOrDefault(); }
            }
            return null;
        }

        public List<StoreItem> GetAllProductsByName(string name)
        {

            List<StoreItem> results = new List<StoreItem>();

            if (name != null)
            {
                string searchKey = string.Empty;
                string searchValue = string.Empty;

                if(Items != null)
                {

                    foreach (var item in Items) // Implement a char search algorithm - NEEDS WORK
                    {
                        if(item.Product.Name.Length >= name.Length)
                        {
                            if (name == item.Product.Name) { results.Add(item); }
                            else if (name.Length <= 2)
                            {
                                searchKey = name.Split('.')[0];

                                searchValue = item.Product.Name.Split('_')[0];

                                if (searchValue.StartsWith(searchKey)) { results.Add(item); }

                            }
                            else
                            {
                                for (int i = 0; i <= 3; i++)
                                {
                                    char nameLetter = name[i];

                                    char Itemletter = item.Product.Name[i];

                                    if (nameLetter == Itemletter) { results.Add(item); }
                                }
                            }
                        }
                    }
                }

                if (results.Count > 0 || results != null) // sorting algorithm for resutls
                {
                    int n = results.Count;

                    for (int i = 1; i < n - 1; ++i)
                    {
                        for (int j = 1; j < n - i - 1; ++j)
                        {
                            if (Items[j].Product.Name.CompareTo(results[j+1]) < Items[j + 1].Product.Name.CompareTo(Items[j]))
                            {
                                StoreItem temp = results[j];
                                results[j] = results[j + 1];
                                results[j + 1] = temp;
                            }
                        }
                    }

                    return results;
                }
            }
            return null;
        }

        public List<StoreItem> GetProductsByQuantity() // sorts the item in Items by quantity (high to low)
        {
            if(Items != null)
            {
                int n = Items.Count;

                for (int i = 0; i < n - 1; ++i)
                {
                    for (int j = 0; j < n - i - 1; ++j)
                    {
                        if (Items[j].Quantity < Items[j + 1].Quantity)
                        {
                            StoreItem temp = Items[j];
                            Items[j] = Items[j + 1];
                            Items[j + 1] = temp;
                        }
                    }
                }

                return Items;
            }
            return null;
        }

        public List<StoreItem> GetProductsByPrice() // sorts the items in Items by price (high to low)
        {

            if (Items != null)
            {
                int n = Items.Count;

                for (int i = 0; i < n - 1; ++i)
                {
                    for (int j = 0; j < n - i - 1; ++j)
                    {
                        if (Items[j].Product.Price < Items[j + 1].Product.Price)
                        {
                            StoreItem temp = Items[j];
                            Items[j] = Items[j + 1];
                            Items[j + 1] = temp;
                        }
                    }
                }

                return Items;
            }
            return null;
        }
    }
}
