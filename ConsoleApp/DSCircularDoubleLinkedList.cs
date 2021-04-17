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
                circularDoubleLinkedList.AddAt(25,6);
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
