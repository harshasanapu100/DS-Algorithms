using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSStackArray
    {
        static void Main(string[] args)
        {

            try
            {
                CustomStackArray customStack = new CustomStackArray(5);
                Console.WriteLine("Custom stack can store only 5 elements");

                Console.WriteLine();
                Console.WriteLine("Creating stack with 5 elements");
                Console.WriteLine("Pushing below 5 elements to the stack");
                Console.WriteLine("10, 20, 30, 40, 50");
                customStack.Push(10);
                customStack.Push(20);
                customStack.Push(30);
                customStack.Push(40);
                customStack.Push(50);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customStack.Print();

                Console.WriteLine();
                Console.WriteLine("Poping item from stack");
                Console.WriteLine();
                customStack.Pop();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customStack.Print();
                customStack.Push(50);

                Console.WriteLine();
                Console.WriteLine("Peeking item from stack");
                int item = customStack.Peek();
                Console.WriteLine("Peek item is: {0}", item);

                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
