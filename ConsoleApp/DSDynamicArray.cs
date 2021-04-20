using System;
using System.Collections.Generic;
using System.Text;
using CustomLibrary;

namespace ConsoleApp
{
    class DSDynamicArray
    {
        static void DSDynamicArrayMain(string[] args)
        {
            try
            {
                DynamicArray dynamicArray = new DynamicArray(5);

                Console.WriteLine("Creating array with 5 elements");
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

                Console.WriteLine();
                Console.WriteLine("Removing array element at index(2) item(30)");
                dynamicArray.RemoveAt(2);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                dynamicArray.Print();
                Console.WriteLine();

                Console.WriteLine("Finding the index of item(40)");
                int index40 = dynamicArray.IndexOf(40);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Index of 40 is {0}", index40);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine("Finding the index of item(30) which is not available in array");
                int index30 = dynamicArray.IndexOf(30);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Index of 30 is {0}", index30);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine("Finding the maximum value in array");
                int max = dynamicArray.Max();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Maximum value in array is: {0}", max);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine("Finding the minimum value in array");
                int min = dynamicArray.Min();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Minimum value in array is: {0}", min);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine("Perform Intersecting with below other array");
                Console.WriteLine("Other array contains 20, 80, 90, 50, 30");
                DynamicArray otherArray = new DynamicArray(5);
                otherArray.Insert(20);
                otherArray.Insert(80);
                otherArray.Insert(90);
                otherArray.Insert(50);
                otherArray.Insert(30);
                DynamicArray intersect = dynamicArray.Intersect(otherArray);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                intersect.Print();

                Console.WriteLine();
                Console.WriteLine("Inserting new item at index(2) value(30)");
                dynamicArray.InsertAt(30,2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                dynamicArray.Print();

                Console.WriteLine();
                Console.WriteLine("Reversing the array");
                dynamicArray.Reverse();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                dynamicArray.Print();

                Console.WriteLine();
                Console.WriteLine("Removing array element at index(-1)");
                dynamicArray.RemoveAt(-1);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
