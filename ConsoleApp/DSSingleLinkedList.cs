using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSSingleLinkedList
    {
        static void DSSingleLinkedListMain(string[] args)
        {
            try
            {
                SingleLinkedList singleLinkedList = new SingleLinkedList();

                Console.WriteLine("Effect of Add First (30,20, 10)");
                singleLinkedList.AddFirst(30);
                singleLinkedList.AddFirst(20);
                singleLinkedList.AddFirst(10);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add Last(40,50)");
                singleLinkedList.AddLast(40);
                singleLinkedList.AddLast(50);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Add At position(3) value(25)");
                singleLinkedList.AddAt(25, 3);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove At Position(3) value(25)");
                singleLinkedList.RemoveAt(3);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Get Kth Node From End( get 3rd node)");
                int result = singleLinkedList.GetKthNodeFromEnd(3);
                Console.WriteLine("3rd node from end is: {0}", result);

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is odd)");
                singleLinkedList.PrintMiddleNode();

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                singleLinkedList.AddLast(60);
                singleLinkedList.PrintMiddleNode();
                singleLinkedList.RemoveLast();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is odd)");
                singleLinkedList.RemoveMiddleNode();
                singleLinkedList.Print();
                singleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Middle Node (when size is even)");
                Console.WriteLine("Adding 1 more node 60 at the end");
                singleLinkedList.AddLast(60);
                singleLinkedList.RemoveMiddleNode();
                singleLinkedList.Print();
                singleLinkedList.AddAt(30, 3);
                singleLinkedList.AddAt(40, 4);
                singleLinkedList.RemoveLast();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First(10)");
                singleLinkedList.RemoveFirst();
                singleLinkedList.Print();
                singleLinkedList.AddFirst(10);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last(50)");
                singleLinkedList.RemoveLast();
                singleLinkedList.Print();
                singleLinkedList.AddLast(50);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Even Nodes");
                singleLinkedList.RemoveEvenNodes();
                singleLinkedList.Print();
                singleLinkedList.AddAt(20, 2);
                singleLinkedList.AddAt(40, 4);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Odd Nodes");
                singleLinkedList.RemoveOddNodes();
                singleLinkedList.Print();
                singleLinkedList.AddAt(10, 1);
                singleLinkedList.AddAt(30, 3);
                singleLinkedList.AddAt(50, 5);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First Node By Value(30)");
                singleLinkedList.RemoveFirstNodeByValue(30);
                singleLinkedList.Print();
                singleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last Node By Value(30)");
                singleLinkedList.RemoveLastNodeByValue(30);
                singleLinkedList.Print();
                singleLinkedList.AddAt(30, 3);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All Nodes By Value(30)");
                Console.WriteLine("Adding 3 more 30's in different places");
                singleLinkedList.AddAt(30, 5);
                singleLinkedList.AddAt(30, 2);
                singleLinkedList.AddAt(30, 1);
                singleLinkedList.Print();
                singleLinkedList.RemoveAllNodesByValue(30);
                Console.WriteLine("After Remove");
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Reverse Linked List");
                singleLinkedList.Reverse();
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All");
                singleLinkedList.RemoveAll();
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Check the given List has loop or not");
                SingleLinkedList list = SingleLinkedList.CreateWithLoop();
                Console.WriteLine("Is List is haivng loop: {0}", list.HasLoop());

                Console.ReadKey();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
