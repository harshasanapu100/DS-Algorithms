using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSCircularSingleLinkedList
    {
        static void Main(string[] args)
        {
            try
            {
                CircularSingleLinkedList circularSingleLinkedList = new CircularSingleLinkedList();

                Console.WriteLine("Effect of Add First (30,20, 10)");
                circularSingleLinkedList.AddFirst(30);
                circularSingleLinkedList.AddFirst(20);
                circularSingleLinkedList.AddFirst(10);
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add Last(40,50)");
                circularSingleLinkedList.AddLast(40);
                circularSingleLinkedList.AddLast(50);
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add At position(3) value(25)");
                circularSingleLinkedList.AddAt(25, 3);
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove At Position(3) value(25)");
                circularSingleLinkedList.RemoveAt(3);
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Get Kth Node From End( get 3rd node)");
                int result = circularSingleLinkedList.GetKthNodeFromEnd(3);
                Console.WriteLine("3rd node from end is: {0}", result);

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is odd)");
                circularSingleLinkedList.PrintMiddleNode();

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                circularSingleLinkedList.AddLast(60);
                circularSingleLinkedList.PrintMiddleNode();
                circularSingleLinkedList.RemoveLast();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is odd)");
                circularSingleLinkedList.RemoveMiddleNode();
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                circularSingleLinkedList.AddLast(60);
                circularSingleLinkedList.RemoveMiddleNode();
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddAt(30, 3);
                circularSingleLinkedList.AddAt(40, 4);
                circularSingleLinkedList.RemoveLast();

                Console.WriteLine();
                Console.WriteLine("Effect Find Node Index of value(50)");
                int index = circularSingleLinkedList.FindNodeIndex(50);
                Console.WriteLine("Node 50 foun at index: {0}", index);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First(10)");
                circularSingleLinkedList.RemoveFirst();
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddFirst(10);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last(50)");
                circularSingleLinkedList.RemoveLast();
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddLast(50);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Even Nodes");
                circularSingleLinkedList.AddLast(60);
                circularSingleLinkedList.RemoveEvenNodes();
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddAt(20, 2);
                circularSingleLinkedList.AddAt(40, 4);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Odd Nodes");
                circularSingleLinkedList.RemoveOddNodes();
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddAt(10, 1);
                circularSingleLinkedList.AddAt(30, 3);
                circularSingleLinkedList.AddAt(50, 5);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First Node By Value(30)");
                circularSingleLinkedList.RemoveFirstNodeByValue(30);
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last Node By Value(50)");
                circularSingleLinkedList.RemoveLastNodeByValue(50);
                circularSingleLinkedList.Print();
                circularSingleLinkedList.AddAt(50, 5);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All Nodes By Value(30)");
                Console.WriteLine("Adding 4 more 30's in different places");
                circularSingleLinkedList.AddAt(30, 5);
                circularSingleLinkedList.AddAt(30, 2);
                circularSingleLinkedList.AddAt(30, 1);
                circularSingleLinkedList.AddLast(30);
                circularSingleLinkedList.Print();
                circularSingleLinkedList.RemoveAllNodesByValue(30);
                Console.WriteLine("After Remove");
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Reverse Linked List");
                circularSingleLinkedList.Reverse();
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All");
                circularSingleLinkedList.RemoveAll();
                circularSingleLinkedList.Print();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
