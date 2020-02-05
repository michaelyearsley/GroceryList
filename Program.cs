using System;
using System.Collections.Generic;

namespace GroceryList
{
    class Program
    {
        static void Main(string[] args)
        {
            var grocerylist = new List<GroceryList>();


            bool adding = true;
            while (adding)
            {
                var newGroceryList = new GroceryList();

                newGroceryList.Item = support.Ask("Enter items: ");

                newGroceryList.Price = double.Parse(support.Ask("Enter price: "));

                newGroceryList.Store = support.Ask("Enter store: ");

                grocerylist.Add(newGroceryList);

                adding = "n" != support.Ask("do you want to enter anot item (y/n)? ");

            }

            foreach (var grocery in grocerylist)
            {
                Console.WriteLine("Item: {0} Price:{1} Store: {2}", grocery.Item, grocery.Price, grocery.Store);
                Console.ReadLine();
            }

        }
    }
    class GroceryList
    {
        public string Item;
        public double Price;
        public string Store;
    }

}
