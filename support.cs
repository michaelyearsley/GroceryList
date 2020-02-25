using System;

namespace GroceryList
{
    class support
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

    }
}
