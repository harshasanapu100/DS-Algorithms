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
                CustomStackArray<int> customStack = new CustomStackArray<int>(5);
                Console.WriteLine("Custom stack can store only 5 elements as we given size");

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
                int result = customStack.Pop();
                Console.WriteLine("Poped value: {0}", result);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customStack.Print();
                customStack.Push(50);

                Console.WriteLine();
                Console.WriteLine("Peeking item from stack");
                int item = customStack.Peek();
                Console.WriteLine("Peek item is: {0}", item);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Reversing a string using Stack");
                Console.WriteLine("Input is abcd and output should be dcba");
                Console.ForegroundColor = ConsoleColor.White;
                string reverse = customStack.Reverse("abcd");
                Console.WriteLine("Reversed string is: {0}", reverse);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Checking whether the expression is balanced or not");
                Console.WriteLine("Input is ([{<a>+<b>}])");
                Console.ForegroundColor = ConsoleColor.White;
                bool isBalanced = customStack.IsExpressionBalanced("([{<a>+<b>}])");
                Console.WriteLine("Is expression balanced: {0}", isBalanced);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Checking whether the expression is having duplicate parenthesis or not");
                Console.WriteLine("Input is ((x+y))");
                Console.ForegroundColor = ConsoleColor.White;
                bool isDuplicateBraces = customStack.IsExpressionHaveDuplicateBraces("((x+y)+((z)))");
                Console.WriteLine("Is expression have duplicate braces: {0}", isDuplicateBraces);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Designing a stack that supports push, pop and retrieving the minimum value in constant time.");
                MinStack minStack = new MinStack();
                Console.WriteLine("Creating stack with 5 elements");
                Console.WriteLine("Pushing below 5 elements to the stack");
                Console.WriteLine("5, 10, 1, 8, 2");
                Console.ForegroundColor = ConsoleColor.White;
                minStack.Push(5);
                minStack.Push(10);
                minStack.Push(1);
                minStack.Push(8);
                minStack.Push(2);
                Console.WriteLine();
                Console.WriteLine("Minimum value in stack is: {0}", minStack.Min());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Implement two stacks in one array.");
                TwoStacks<int> twoStacks = new TwoStacks<int>(5);
                Console.WriteLine("Creating stack with 5 elements");
                Console.WriteLine("Pushing below below first 2 elements at the begining remaing 3 elements at the ending of the stack");
                Console.WriteLine("10, 20, 30, 40, 50");
                Console.ForegroundColor = ConsoleColor.White;
                twoStacks.Push1(10);
                twoStacks.Push1(20);
                twoStacks.Push2(30);
                twoStacks.Push2(40);
                twoStacks.Push2(50);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                twoStacks.Print();

                Console.WriteLine();
                Console.WriteLine("Peek of stack begining: {0}", twoStacks.Peek1());
                Console.WriteLine("Peek of stack ending: {0}", twoStacks.Peek2());
                Console.WriteLine("Poping of stack begining: {0}", twoStacks.Pop1());
                Console.WriteLine("Poping of stack ending: {0}", twoStacks.Pop2());
                Console.WriteLine();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Reversing a stack with out using any data structure recursively");
                StackReverse stackReverse = new StackReverse();
                Console.WriteLine("Creating stack with 5 elements");
                Console.WriteLine("Pushing below 5 elements to the stack");
                Console.WriteLine("10, 20, 30, 40, 50");
                Console.ForegroundColor = ConsoleColor.White;

                stackReverse.stack.Push(10);
                stackReverse.stack.Push(20);
                stackReverse.stack.Push(30);
                stackReverse.stack.Push(40);
                stackReverse.stack.Push(50);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Original Stack");
                Console.ForegroundColor = ConsoleColor.White;
                stackReverse.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Performing Reverse");
                Console.ForegroundColor = ConsoleColor.White;
                stackReverse.Reverse();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Reversed Stack");
                Console.ForegroundColor = ConsoleColor.White;
                stackReverse.Print();

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
