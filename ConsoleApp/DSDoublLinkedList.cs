using System;
using CustomLibrary;

namespace ConsoleApp
{
    public class DSDoublLinkedList
    {
        static void DSDoublLinkedListMain(string[] args)
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
                Console.WriteLine("Effect of Get Kth Node From End( get 3rd node)");
                int result = doubleLinkedList.GetKthNodeFromEnd(3);
                Console.WriteLine("3rd node from end is: {0}", result);

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is odd)");
                doubleLinkedList.PrintMiddleNode();

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                doubleLinkedList.AddLast(60);
                doubleLinkedList.PrintMiddleNode();
                doubleLinkedList.RemoveLast();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is odd)");
                doubleLinkedList.RemoveMiddleNode();
                doubleLinkedList.Print();
                doubleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                doubleLinkedList.AddLast(60);
                doubleLinkedList.RemoveMiddleNode();
                doubleLinkedList.Print();
                doubleLinkedList.AddAt(30, 3);
                doubleLinkedList.AddAt(40, 4);
                doubleLinkedList.RemoveLast();

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
                Console.WriteLine("Effect of Remove Even Nodes");
                doubleLinkedList.RemoveEvenNodes();
                doubleLinkedList.Print();
                doubleLinkedList.AddAt(20, 2);
                doubleLinkedList.AddAt(40, 4);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Odd Nodes");
                doubleLinkedList.RemoveOddNodes();
                doubleLinkedList.Print();
                doubleLinkedList.AddAt(10, 1);
                doubleLinkedList.AddAt(30, 3);
                doubleLinkedList.AddAt(50, 5);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First Node By Value(30)");
                doubleLinkedList.RemoveFirstNodeByValue(30);
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last Node By Value(30)");
                doubleLinkedList.RemoveLastNodeByValue(30);
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All Nodes By Value(30)");
                Console.WriteLine("Adding 3 more 30's in different places");
                doubleLinkedList.AddAt(30, 5);
                doubleLinkedList.AddAt(30, 2);
                doubleLinkedList.AddAt(30, 1);
                doubleLinkedList.Print();
                doubleLinkedList.RemoveAllNodesByValue(30);
                Console.WriteLine("After Remove");
                doubleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Reverse Linked List");
                doubleLinkedList.Reverse();
                doubleLinkedList.Print();

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
