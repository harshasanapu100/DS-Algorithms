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
                Console.WriteLine("Effect of Find Node Index By value(25)");
                int index = singleLinkedList.FindNodeIndex(25);
                Console.WriteLine("Index of 25 is {0}", index);

                Console.WriteLine();
                Console.WriteLine("Effect of Remove At Position(3) value(25)");
                singleLinkedList.RemoveAt(3);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Get Kth Node From End(30)");
                singleLinkedList.GetKthNodeFromEnd(3);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Print Middle Node");
                singleLinkedList.PrintMiddleNode();

                Console.WriteLine();
                Console.WriteLine("Effect Reverse Linked List");
                singleLinkedList.Reverse();
                singleLinkedList.Print();
                singleLinkedList.Reverse();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove First(10)");
                singleLinkedList.RemoveFirst();
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove Last(50)");
                singleLinkedList.RemoveLast();
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Even Nodes");
                singleLinkedList.RemoveEvenNodes();
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Odd Nodes");
                singleLinkedList.RemoveOddNodes();
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete First Node By Value(30)");
                singleLinkedList.RemoveFirstNodeByValue(30);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete Last Node By Value(40)");
                singleLinkedList.RemoveLastNodeByValue(40);
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Delete All Nodes By Value(30)");
                Console.WriteLine("Adding 3 more 30's in different places");
                singleLinkedList.AddAt(30, 5);
                singleLinkedList.AddAt(30, 2);
                singleLinkedList.AddAt(30, 1);
                singleLinkedList.Print();
                singleLinkedList.RemoveAllNodesByValue(30);
                Console.WriteLine("After Delte");
                singleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove All");
                singleLinkedList.RemoveAll();
                singleLinkedList.Print();

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
