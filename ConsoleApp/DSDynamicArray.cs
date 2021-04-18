using System;
using System.Collections.Generic;
using System.Text;
using CustomLibrary;

namespace ConsoleApp
{
    class DSDynamicArray
    {
        static void Main(string[] args)
        {
            DynamicArray dynamicArray = new DynamicArray(5);

            Console.WriteLine("Array created with 5 elements");
            Console.WriteLine("Adding below 5 elements to the array");
            Console.WriteLine("10, 20, 30, 40, 50");
            dynamicArray.Insert(10);
            dynamicArray.Insert(20);
            dynamicArray.Insert(30);
            dynamicArray.Insert(40);
            dynamicArray.Insert(50);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Printing the elements");
            Console.ForegroundColor = ConsoleColor.White;
            dynamicArray.Print();

            Console.WriteLine();
            Console.WriteLine("Adding below element as 6th element to the array");
            Console.WriteLine("60");
            Console.WriteLine();
            dynamicArray.Insert(60);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Printing the elements");
            Console.ForegroundColor = ConsoleColor.White;
            dynamicArray.Print();

            Console.WriteLine();
            Console.WriteLine("Adding below 2 more elements to the array");
            Console.WriteLine("70, 80");
            Console.WriteLine();
            dynamicArray.Insert(70);
            dynamicArray.Insert(80);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Printing the elements");
            Console.ForegroundColor = ConsoleColor.White;
            dynamicArray.Print();

            Console.ReadLine();
        }
    }
}
