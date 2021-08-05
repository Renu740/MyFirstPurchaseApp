using System;
using System.Collections.Generic;
using System.Text;
using Humanizer;

namespace PurchasingLibrary
{
    public class CustomerDetails
    {
        public string CustomerName { get; }
        public string Address { get; }

        List<ItemCollection> lsItemCollection = new List<ItemCollection>();
        public CustomerDetails(string cName, string cAddress)
        {
            CustomerName = cName;
            Address = cAddress;
        }

        public void PurchaseItem(string item, decimal price)
        {
            if (price < 1)
                throw new InvalidOperationException("Price should be greater than 1");
            else
                Console.WriteLine($"{item}\t\t {price}");

            var data = new ItemCollection(item, price);
            lsItemCollection.Add(data);
        }
        public void GetTotalAmount()
        {
            decimal amount = 0;
            foreach (var item in lsItemCollection)
            {
                amount += item.Price;
            }
            Console.WriteLine($"\nYour Total Amount is: {amount}");

            //For Humizer NuGet Packages
            Console.WriteLine("Your Amount for Humans is:" + ((int)amount).ToWords());
        }
    }
}
