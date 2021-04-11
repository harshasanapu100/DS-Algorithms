using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSSingleLinkedList
    {
        static void Main(string[] args)
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
            singleLinkedList.AddAt(25,3);
            singleLinkedList.Print();

            Console.WriteLine();
            Console.WriteLine("Effect of Remove At Position(3) value(25)");
            singleLinkedList.RemoveAt(3);
            singleLinkedList.Print();


            //Console.WriteLine();
            //Console.WriteLine("Effect of Remove First(10)");
            //singleLinkedList.RemoveFirst();
            //singleLinkedList.Print();

            //Console.WriteLine();
            //Console.WriteLine("Effect of Remove Last(50)");
            //singleLinkedList.RemoveLast();
            //singleLinkedList.Print();

            //Console.WriteLine();
            //Console.WriteLine("Effect of Delete All");
            //singleLinkedList.DeleteAll();
            //singleLinkedList.Print();

            Console.WriteLine();
            Console.WriteLine("Effect of Delete Even Nodes");
            singleLinkedList.DeleteAll();
            singleLinkedList.Print();

            Console.ReadKey();
        }
    }
}
