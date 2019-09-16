using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTest.DAL
{
    public class ShoppingCart : IDisposable
    {
        public List<Item> Items = new List<Item>();

        public int ItemCount
        {
            get { return Items.Count; }
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(int index)
        {
            Items.RemoveAt(index);
        }

        public void Dispose()
        {
            
        }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
    }
}
