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
                circularSingleLinkedList.AddAt(25,3);
                circularSingleLinkedList.Print();

                Console.WriteLine();
                Console.WriteLine("Effect of Remove At Position(3) value(25)");
                circularSingleLinkedList.RemoveAt(3);
                circularSingleLinkedList.Print();

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


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
