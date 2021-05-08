using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSQueueLinkedList
    {
        static void DSQueueLinkedListMain(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the Queue with Linked List");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 10, 20, 30, 40, 50 elements to queue");
                Console.ForegroundColor = ConsoleColor.White;

                CustomQueueLinkedList customQueueLinkedList = new CustomQueueLinkedList();
                customQueueLinkedList.Enqueue(10);
                customQueueLinkedList.Enqueue(20);
                customQueueLinkedList.Enqueue(30);
                customQueueLinkedList.Enqueue(40);
                customQueueLinkedList.Enqueue(50);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from queue");
                Console.ForegroundColor = ConsoleColor.White;
                int front = customQueueLinkedList.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = customQueueLinkedList.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding new item as 11");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Enqueue(11);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding new item as 22");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Enqueue(22);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueLinkedList.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Peeking the element");
                Console.ForegroundColor = ConsoleColor.White;
                front = customQueueLinkedList.Peek();
                Console.WriteLine("Peek item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
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
