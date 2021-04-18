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
                Console.WriteLine("Effect of Delete Middle Node (when size is odd)");
                circularDoubleLinkedList.RemoveMiddleNode();
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                circularDoubleLinkedList.AddLast(60);
                circularDoubleLinkedList.RemoveMiddleNode();
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(30, 3);
                circularDoubleLinkedList.AddAt(40, 4);
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

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Even Nodes");
                circularDoubleLinkedList.RemoveEvenNodes();
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(20, 2);
                circularDoubleLinkedList.AddAt(40, 4);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Odd Nodes");
                circularDoubleLinkedList.RemoveOddNodes();
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(10, 1);
                circularDoubleLinkedList.AddAt(30, 3);
                circularDoubleLinkedList.AddAt(50, 5);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First Node By Value(30)");
                circularDoubleLinkedList.RemoveFirstNodeByValue(30);
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last Node By Value(30)");
                circularDoubleLinkedList.RemoveLastNodeByValue(30);
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All Nodes By Value(30)");
                Console.WriteLine("Adding 3 more 30's in different places");
                circularDoubleLinkedList.AddAt(30, 5);
                circularDoubleLinkedList.AddAt(30, 2);
                circularDoubleLinkedList.AddAt(30, 1);
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.RemoveAllNodesByValue(30);
                Console.WriteLine("After Remove");
                circularDoubleLinkedList.Print();
                circularDoubleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Reverse Linked List");
                circularDoubleLinkedList.Reverse();
                circularDoubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All");
                circularDoubleLinkedList.RemoveAll();
                circularDoubleLinkedList.Print();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
