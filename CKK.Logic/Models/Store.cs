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
            if (quantity < 0) 
            {
                throw new InventoryItemStockTooLowException();
            }


            for (int i = 0; i < Items.Count; i++)
            {

                if (Items[i].Product.Id == prod.Id)
                {
                    Items[i].Quantity = Items[i].Quantity + quantity;
                    return Items[i];
                }

            }
            var item = new StoreItem(prod, quantity);
            Items.Add(item);
            return item;
        }
        public StoreItem RemoveStoreItem(int id, int quantity) // removes store item
        {
            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            var item = FindStoreItemById(id);
            
            if (item == null)
            {
                throw new ProductDoesNotExistException();
            }

            for (int i = 0; i < Items.Count; i++)
            {
                    if (Items[i].Product.Id == id)
                    {
                        Items[i].Quantity = Items[i].Quantity - quantity;
                        if (Items[i].Quantity < 0)
                        {
                            Items[i].Quantity = 0;
                        }
                        return Items[i];
                    }
            }
            return null;
        }
        public List<StoreItem> GetStoreItems() // gets store item
        {
            return Items;
        }
        public StoreItem FindStoreItemById(int id) // finds store item by ID
        {
            if(id < 0)
            {
                throw new InvalidIdException();
            }
            else
            {
                var matchingId =
                    from item in Items
                    where item.Product.Id == id
                    select item;

                if (matchingId.Any())
                {
                    return matchingId.FirstOrDefault();
                }
                else { return null; }
            }
        }
    }
}
