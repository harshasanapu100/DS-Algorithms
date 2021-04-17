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
