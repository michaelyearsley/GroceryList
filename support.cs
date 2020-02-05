using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryList
{
    class support
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
        class GroceryList
        {
            public string Item;
            public double Price;
            public string Store;
        }
    }
}
