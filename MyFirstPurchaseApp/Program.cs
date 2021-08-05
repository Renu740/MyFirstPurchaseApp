using PurchasingLibrary;
using System;

namespace MyFirstPurchaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var customer = new CustomerDetails("Renu", "Baroda");
                var t = new ItemCollection("Fruits", 90);
                Console.WriteLine($"Welcome {customer.CustomerName} in D-Mart at {customer.Address} location. \n");

                Console.WriteLine("Your are Purchasing Following Item:");
                Console.WriteLine("\nItem\t\tPrice");
                customer.PurchaseItem("Fruits", 90);
                customer.PurchaseItem("Coffee", 120);
                customer.PurchaseItem("Cloths", 110);
                customer.PurchaseItem("Juice", 80);
                //customer.PurchaseItem("Tea", -5);
                customer.GetTotalAmount();

                Console.WriteLine($"\nThanks for the shopping {customer.CustomerName} Please visit again.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
