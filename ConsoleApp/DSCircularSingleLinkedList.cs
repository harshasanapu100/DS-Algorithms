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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
