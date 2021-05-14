using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSHashTable
    {
        static void Main(string[] args)
        {
            try
            {
                #region CustomHashTable
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the hash table contains key as int and value as string with the capacity of 5 elements");
                Console.ForegroundColor = ConsoleColor.White;
                CustomHashTable customHashTable = new CustomHashTable(5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements to hash table");
                Console.ForegroundColor = ConsoleColor.White;

                customHashTable.Add(0, "Harsha");
                customHashTable.Add(1, "Amar");
                customHashTable.Add(2, "Prudhvi");
                customHashTable.Add(3, "Ashok");
                customHashTable.Add(4, "Raja");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTable.Print();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing somemore elements to hash table");
                Console.ForegroundColor = ConsoleColor.White;

                customHashTable.Add(12, "Pavani");
                customHashTable.Add(19, "Pallavi");
                customHashTable.Add(16, "Sravanti");
                customHashTable.Add(15, "Madhavi");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTable.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Get the item by key");
                Console.ForegroundColor = ConsoleColor.White;
                string result = customHashTable.Get(2);
                Console.WriteLine("key : {0} value: {1}", 2, result);
                result = customHashTable.Get(19);
                Console.WriteLine("key : {0} value: {1}", 19, result);
                result = customHashTable.Get(4);
                Console.WriteLine("key : {0} value: {1}", 4, result);
                result = customHashTable.Get(7);
                Console.WriteLine("key : {0} value: {1}", 7, result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Remove the item by key");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Removed key is 4");
                customHashTable.Remove(4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTable.Print();

                Console.WriteLine();
                Console.WriteLine("Removed key is 15");
                customHashTable.Remove(15);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTable.Print();

                Console.ReadKey();
                #endregion
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
