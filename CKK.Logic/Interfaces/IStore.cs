using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        // creates the methods required for a class using this Interface
        StoreItem AddStoreItem(Product prod, int quantity);
        StoreItem RemoveStoreItem(int id, int quantity);
        List<StoreItem> GetStoreItems();
        StoreItem FindStoreItemById(int id);
    }
}
