using System;
using System.Collections.Generic;
using CustomLibrary;

namespace ConsoleApp
{
    class DSQueueArray
    {
        static void DSQueueArrayMain(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the circular queue with Array");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 10, 20, 30, 40, 50 elements to queue");
                Console.ForegroundColor = ConsoleColor.White;

                CustomQueueArray customQueueArray = new CustomQueueArray(5);
                customQueueArray.Enqueue(10);
                customQueueArray.Enqueue(20);
                customQueueArray.Enqueue(30);
                customQueueArray.Enqueue(40);
                customQueueArray.Enqueue(50);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from queue");
                Console.ForegroundColor = ConsoleColor.White;
                int front = customQueueArray.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = customQueueArray.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding new item as 11");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Enqueue(11);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding new item as 22");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Enqueue(22);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Peeking the element");
                Console.ForegroundColor = ConsoleColor.White;
                front = customQueueArray.Peek();
                Console.WriteLine("Peek item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
