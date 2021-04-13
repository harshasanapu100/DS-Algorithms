using System;
using CustomLibrary;

namespace ConsoleApp
{
    public class DSDoublLinkedList
    {
        static void Main(string[] args)
        {
            try
            {
                DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

                Console.WriteLine("Effect of Add First (30,20, 10)");
                doubleLinkedList.AddFirst(30);
                doubleLinkedList.AddFirst(20);
                doubleLinkedList.AddFirst(10);
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add Last(40,50)");
                doubleLinkedList.AddLast(40);
                doubleLinkedList.AddLast(50);
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add At position(3) value(25)");
                doubleLinkedList.AddAt(25, 3);
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove At Position(3) value(25)");
                doubleLinkedList.RemoveAt(3);
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First(10)");
                doubleLinkedList.RemoveFirst();
                doubleLinkedList.Print();
                doubleLinkedList.AddFirst(10);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last(50)");
                doubleLinkedList.RemoveLast();
                doubleLinkedList.Print();
                doubleLinkedList.AddLast(50);

                Console.WriteLine();
                Console.WriteLine("Effect of Reverse Linked List");
                doubleLinkedList.Reverse();
                doubleLinkedList.Print();
                doubleLinkedList.Reverse();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All");
                doubleLinkedList.RemoveAll();
                doubleLinkedList.Print();

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
