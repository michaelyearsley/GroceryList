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
                //System.Collections.Generic 2
                grocerylist.Add(newGroceryList);
                //System 3 = ToLower 
                //System 4 = ToChar
                adding = 'n' != Char.ToLower(Convert.ToChar(support.Ask("do you want to enter anot item (y/n)? ")));
            }
            //System.Linq 1
            double total = grocerylist.Sum(x => x.Price);
            //System.Linq 2
            double average = grocerylist.Average(x => x.Price);
            //System.Linq 3
            double max = grocerylist.Max(x => x.Price);
            //System.Linq 4
            int count = grocerylist.Count();
            //System.Linq 5
            grocerylist = grocerylist.OrderBy(x => x.Item).ToList();
            

            //system 5
            foreach (var grocery in grocerylist)
            {
                Console.WriteLine("Item: {0} Price:{1} Store: {2}", grocery.Item, grocery.Price, grocery.Store);
            }
            Console.WriteLine("you have {0} items with totatl price {1} and  an average price {2} and the max priced item was {3}",count ,total ,average, max);
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
