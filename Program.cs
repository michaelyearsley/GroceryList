using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryList
{
    /* 1st namespace for system is enum which is used as a numerator to pull certain values
     *  https://docs.microsoft.com/en-us/dotnet/api/system.enum?view=netframework-4.8*/
    enum Store
    {
        Costco,
        Winco,
        Fred_Myers
    }
    class Program
    {
        /* 1st namespace for System.Collections.Generic list<T> creates a list type object acessed by index
         * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8 */
        static List<GroceryList> grocerylist = new List<GroceryList>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Data");

            /* 2nd namespace for system boolean which will return true or false
             * https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.8 */
            bool adding = true;

            while (adding)
            {
                var newGroceryList = new GroceryList();

                newGroceryList.Item = (support.Ask("Enter items: "));
                /* 3rd namespace for system Double.Parse converts a string into a double-precision floating-point number
                 * https://docs.microsoft.com/en-us/dotnet/api/system.double.parse?view=netframework-4.8 */
                newGroceryList.Price = double.Parse(support.Ask("Enter price: "));

                newGroceryList.Store = (Store)int.Parse(support.Ask("Enter store: (type the corresponding number): \n 0: Costco \n 1: Winco \n 2: Fred meyers: "));
                /*2nd namespace for System.Collections.Generic Add which adds object to the end of the list
                 * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=netframework-4.8 */
                grocerylist.Add(newGroceryList);
                /* 4th namespace for system Char.ToLower converts a single caracter to lower case
                 * https://docs.microsoft.com/en-us/dotnet/api/system.char.tolower?view=netframework-4.8 */
                /*5th namespace for system Convert.ToChar converts a specific value to  a single character
                 * https://docs.microsoft.com/en-us/dotnet/api/system.convert.tochar?view=netframework-4.8 */
                adding = 'n' != Char.ToLower(Convert.ToChar(support.Ask("Do you want to enter another item (y/n)? ")));
            }
            Console.WriteLine("\n This is system.Linq");    
            
            Console.WriteLine("Boolean test: " + adding);
            /*1st namespace for system.Linq Sum which adds all the price values together
             * https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.8 */
            double total = grocerylist.Sum(add => add.Price);
            Console.WriteLine("Grocery Totals: " + total);
            /*2nd namespace for system.Linq Average which finds out the average cost of the price
             * https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=netframework-4.8 */
            double average = grocerylist.Average(aver => aver.Price);
            Console.WriteLine("Grocery Average: " + Math.Round(average, 2));
            /*3rd namespace for system.Linq Max which finds price in the list with the max value
             * https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max?view=netframework-4.8 */
            double max = grocerylist.Max(max => max.Price);
            Console.WriteLine("Grocery Max: " + max);
            /*4th namespace for system.Linq count which finds out how many items in the list
             * https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=netframework-4.8 */
            int count = grocerylist.Count();
            Console.WriteLine("Grocery Totals: " + count);
            /*5th namespace for system.Linq oderby which organizes the list in ascending order
             * https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=netframework-4.8 */
            grocerylist = grocerylist.OrderBy(grocerylist => grocerylist.Item).ToList();

            Console.WriteLine("\n The organized list");

            foreach (var grocery in grocerylist)
            {
                Console.WriteLine("Item: {0} Price:{1} Store: {2}", grocery.Item, grocery.Price, grocery.Store);
            }
            Console.WriteLine("\n Finding, removing and reprinting list");

            string item = support.Ask("What item do you want to look for: ");
            FindItem(item);
            RemoveItem(Char.ToLower(Char.ToLower(Convert.ToChar(support.Ask("do you you want to remove this item y/n: ")))), item);
            Console.ReadLine();

        }
        static void FindItem(string item)
        {
            /* 3rd namespace for System.Collections.Generic Find which looks through the list for a item
             * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=netframework-4.8 */
            if (grocerylist.Find(f => f.Item == item) != null)
            {
                var found = grocerylist.Find(f => f.Item == item);
                Console.WriteLine("Item: {0} Price:{1}", found.Item, found.Price);
            }
            else
                Console.WriteLine("nothing found");  
        }
        static void RemoveItem(Char answer, string item)
        {

            if (answer == 'y')
            {
                /*4th namespace for System.Collections.Generic removeAll remove all the elments that match the conditions from the list
                 * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeall?view=netframework-4.8 */
                grocerylist.RemoveAll(x => x.Item == item);
                foreach (var grocery in grocerylist)
                {
                    /*5th namespace for System.Collections.Generic count which counts the remain lines
                     * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=netframework-4.8 */
                    Console.WriteLine("Item: {0} Price:{1} Store: {2} number of elements:{3}", grocery.Item, grocery.Price, grocery.Store, grocerylist.Count);
                }
                
            }
            Console.WriteLine("finished");
            Console.ReadLine();

        }
    }
    class GroceryList
    {
        public string Item;
        public double Price;
        public Store Store;
    }

}
