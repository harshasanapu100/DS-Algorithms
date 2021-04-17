using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSCircularDoubleLinkedList
    {
        static void Main(string[] args)
        {
            try
            {
                CircularDoubleLinkedList circularDoubleLinkedList = new CircularDoubleLinkedList();

                Console.WriteLine("Effect of Add First (30,20, 10)");
                circularDoubleLinkedList.AddFirst(30);
                circularDoubleLinkedList.AddFirst(20);
                circularDoubleLinkedList.AddFirst(10);
                circularDoubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add Last(40,50)");
                circularDoubleLinkedList.AddLast(40);
                circularDoubleLinkedList.AddLast(50);
                circularDoubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add At position(3) value(25)");
                circularDoubleLinkedList.AddAt(25, 3);
                circularDoubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove At Position(3) value(25)");
                circularDoubleLinkedList.RemoveAt(3);
                circularDoubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Get Kth Node From End( get 3rd node)");
                int result = circularDoubleLinkedList.GetKthNodeFromEnd(5);
                Console.WriteLine("3rd node from end is: {0}", result);

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is odd)");
                circularDoubleLinkedList.PrintMiddleNode();

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                circularDoubleLinkedList.AddLast(60);
                circularDoubleLinkedList.PrintMiddleNode();
                circularDoubleLinkedList.RemoveLast();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First(10)");
                circularDoubleLinkedList.RemoveFirst();
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddFirst(10);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last(50)");
                circularDoubleLinkedList.RemoveLast();
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddLast(50);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
