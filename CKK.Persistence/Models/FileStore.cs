using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistence.Interfaces;
using CKK.Persistence.Models;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace CKK.Persistence.Models
{
    public class FileStore : IStore, ISavable, ILoadable
    {
        public FileStream FileStream;

        public static readonly string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Persistance" + Path.DirectorySeparatorChar + "StoreItems.dat";

        public List<StoreItem> Items = new List<StoreItem>();

        public int IdCounter = 0;

        public FileStore() { CreatePath(); }

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if(quantity < 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            for(int i = 0; i < Items.Count; i++)
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

                prod.Id = randomId.Next(100,500);

                var preExistingItem = FindStoreItemById(prod.Id);

                if (preExistingItem == null) { prod.Id = prod.Id; }
                else if (preExistingItem.Product.Id == prod.Id) { prod.Id = 0; }
            }
            
            var item = new StoreItem(prod, quantity);
            Items.Add(item);

            Save();

            return item;
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if(quantity < 0) { throw new ArgumentOutOfRangeException(); }

            var temp = FindStoreItemById(id);

            if (temp == null || Items.Count == 0) { throw new ProductDoesNotExistException(); }
            else if (temp != null || Items.Count > 0)
            {
                if (temp.Quantity - quantity <= 0)
                {
                    temp.Quantity = 0;
                    Save();
                    return temp;
                }
                else
                {
                    temp.Quantity = temp.Quantity - quantity;
                    Save();
                    return temp;
                }
            }

            return null;
        }

        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0) { throw new InvalidIdException(); }
            else if (id > 0)
            {
                var matchingId =
                    from item in Items
                    where item.Product.Id == id
                    select item;

                if (matchingId.Any()) { return matchingId.FirstOrDefault(); }
            }
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

        public void DeleteStoreItem(int id)
        {
            if(id < 0) { throw new InvalidIdException(); }

            var temp = FindStoreItemById(id);

            if(temp == null || Items.Count == 0) { throw new ProductDoesNotExistException(); }
            else if(temp != null || Items.Count > 0) { Items.Remove(temp); }

            Save();
        }

        public void Save()
        {
            JsonSerializer.Serialize(FileStream, Items);
        }

        public void Load()
        {
            try 
            {
                if (File.Exists(FilePath))
                {
                    object deserializedFile = JsonSerializer.Deserialize<StoreItem>(FilePath);

                    Items = deserializedFile as List<StoreItem>;
                }
            }
            catch (SerializationException) { }
        }

        public void CreatePath()
        {
            try
            {
                if (!Directory.Exists(FilePath)) { Directory.CreateDirectory(FilePath); }
            }
            catch (IOException) { }
        }

        public List<StoreItem> GetAllProductsByName(string name)
        {

            List<StoreItem> results = new List<StoreItem>();

            if (name != null)
            {
                string searchKey = string.Empty;
                string searchValue = string.Empty;

                if (Items != null)
                {

                    foreach (var item in Items) // Implement a char search algorithm - NEEDS WORK
                    {
                        if (item.Product.Name.Length >= name.Length)
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
                            if (Items[j].Product.Name.CompareTo(results[j + 1]) < Items[j + 1].Product.Name.CompareTo(Items[j]))
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

        public List<StoreItem> GetProductsByQuantity()
        {
            List<StoreItem> results = new List<StoreItem>();

            results = Items;

            if (Items != null)
            {
                int n = results.Count;

                for (int i = 1; i < n - 1; ++i)
                {
                    for (int j = 1; j < n - i - 1; ++j)
                    {
                        if (results[j].Product.Price < results[j + 1].Product.Price)
                        {
                            StoreItem temp = results[j];
                            results[j] = Items[j + 1];
                            results[j + 1] = temp;
                        }
                    }
                }

                return results;
            }
            return null;
        }

        public List<StoreItem> GetProductsByPrice()
        {
            List<StoreItem> results = new List<StoreItem>();

            results = Items;

            if (Items != null)
            {
                int n = results.Count;

                for (int i = 1; i < n - 1; ++i)
                {
                    for (int j = 1; j < n - i - 1; ++j)
                    {
                        if (results[j].Product.Price < results[j + 1].Product.Price)
                        {
                            StoreItem temp = results[j];
                            results[j] = Items[j + 1];
                            results[j + 1] = temp;
                        }
                    }
                }

                return results;
            }
            return null;
        }
    }
}
