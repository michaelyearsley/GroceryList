using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic 1
            var grocerylist = new List<GroceryList>();



            // system 1
            bool adding = true;
            // system 2
            while (adding)
            {
                var newGroceryList = new GroceryList();

                newGroceryList.Item = support.Ask("Enter items: ");

                newGroceryList.Price = double.Parse(support.Ask("Enter price: "));

                newGroceryList.Store = support.Ask("Enter store: ");

                grocerylist.Add(newGroceryList);
                

                adding = "n" != support.Ask("do you want to enter anot item (y/n)? ");

            }

            //System.Linq 1
            grocerylist = grocerylist.OrderBy(x => x.Item).ToList();
            //system 3
            foreach (var grocery in grocerylist)
            {
                Console.WriteLine("Item: {0} Price:{1} Store: {2}", grocery.Item, grocery.Price, grocery.Store);
                
            }
            Console.ReadLine();
        }
    }
    class GroceryList
    {
        public string Item;
        public double Price;
        public string Store;
    }

}
