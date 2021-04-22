using System;
using System.Collections.Generic;
using System.Text;
using CustomLibrary;

namespace ConsoleApp
{
     class DSStackLinkedList
    {
        static void Main(string[] args)
        {
            try
            {
                CustomStackLinkedList<int> customStackLinkedList = new CustomStackLinkedList<int>(5);
                Console.WriteLine("Custom stack can store only 5 elements as we given size");

                Console.WriteLine();
                Console.WriteLine("Creating stack with 5 elements");
                Console.WriteLine("Pushing below 5 elements to the stack");
                Console.WriteLine("10, 20, 30, 40, 50");
                customStackLinkedList.Push(10);
                customStackLinkedList.Push(20);
                customStackLinkedList.Push(30);
                customStackLinkedList.Push(40);
                customStackLinkedList.Push(50);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customStackLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Poping item from stack");
                int result = customStackLinkedList.Pop();
                Console.WriteLine("Poped value: {0}", result);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customStackLinkedList.Print();
                customStackLinkedList.Push(50);

                Console.WriteLine();
                Console.WriteLine("Peeking item from stack");
                int item = customStackLinkedList.Peek();
                Console.WriteLine("Peek item is: {0}", item);

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
