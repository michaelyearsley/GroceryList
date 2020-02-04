using System;
using System.Collections.Generic;

namespace GroceryList
{
    class Program
    {
        static void Main(string[] args)
        {
            var grocerylist = new List<GroceryList>();

            var adding = true;

            while (adding)
            {
                var newList = new GroceryList();

                newList.Product = Support.Ask("What product do you want to add: ");
                newList.Price = double.Parse(Support.Ask("What is the price"));
                newList.Store = Support.Ask("What product do you want to add: ");

                GroceryList.Count++;

                Console.Write("Do you want to add another (y/n): ");
                string again = Console.ReadLine();
                if (again != "y")
                {
                    adding = false;
                }
            }
            for (int i = 0; i < GroceryList.Count; i++)
            {
                Console.WriteLine("Your Costco List: ");
                string item = GroceryList[i];

            }
        }
    }
    class GroceryList
    {
        static public int Count = 0;

        public string Product;
        public double Price;
        public string Store;
    }
}
