using System;

namespace PurchasingLibrary
{
    public class ItemCollection
    {
        public string Item { get; }
        public decimal Price { get; }
        public ItemCollection(string item, decimal price)
        {
            Item = item;
            Price = price;
        }
    }
}
