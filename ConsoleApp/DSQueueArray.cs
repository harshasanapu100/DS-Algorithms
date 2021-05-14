using System;
using System.Collections.Generic;
using CustomLibrary;

namespace ConsoleApp
{
    class DSQueueArray
    {
        static void Main(string[] args)
        {
            try
            {
                #region CustomQueueArray
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the circular Queue with Array");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 10, 20, 30, 40, 50 elements to Queue");
                Console.ForegroundColor = ConsoleColor.White;

                CustomQueueArray customQueueArray = new CustomQueueArray(5);
                customQueueArray.Enqueue(10);
                customQueueArray.Enqueue(20);
                customQueueArray.Enqueue(30);
                customQueueArray.Enqueue(40);
                customQueueArray.Enqueue(50);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                int front = customQueueArray.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = customQueueArray.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding new item as 11");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Enqueue(11);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding new item as 22");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Enqueue(22);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customQueueArray.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Peeking the element");
                Console.ForegroundColor = ConsoleColor.White;
                front = customQueueArray.Peek();
                Console.WriteLine("Peek item is: {0}", front);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                #endregion

                #region ReverseQueue
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Reversing the Queue");
                Console.ForegroundColor = ConsoleColor.White;

                ReverseQueue reverseQueue = new ReverseQueue();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements of Queue before reversing");
                Console.ForegroundColor = ConsoleColor.White;
                reverseQueue.Print();

                reverseQueue.Reverse();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements of Queue after reversing");
                Console.ForegroundColor = ConsoleColor.White;
                reverseQueue.Print();
                #endregion

                #region QueueWithTwoStacks
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implemeting Queue with two Stacks");
                Console.ForegroundColor = ConsoleColor.White;

                QueueWithTwoStacks queueWithTwoStacks = new QueueWithTwoStacks();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 10, 20, 30 elements to Queue");
                Console.ForegroundColor = ConsoleColor.White;
                queueWithTwoStacks.Enqueue(10);
                queueWithTwoStacks.Enqueue(20);
                queueWithTwoStacks.Enqueue(30);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithTwoStacks.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithTwoStacks.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding element 40 to the Queue");
                Console.ForegroundColor = ConsoleColor.White;
                queueWithTwoStacks.Enqueue(40);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithTwoStacks.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithTwoStacks.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.WriteLine();
                #endregion

                #region QueueWithOneStacks
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Implemeting Queue with one Stack");

                QueueWithOneStack queueWithOneStack = new QueueWithOneStack();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 10, 20, 30 elements to Queue");
                Console.ForegroundColor = ConsoleColor.White;
                queueWithOneStack.Enqueue(10);
                queueWithOneStack.Enqueue(20);
                queueWithOneStack.Enqueue(30);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithOneStack.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithOneStack.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Adding element 40 to the Queue");
                Console.ForegroundColor = ConsoleColor.White;
                queueWithOneStack.Enqueue(40);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing the element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithOneStack.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing one more element from Queue");
                Console.ForegroundColor = ConsoleColor.White;
                front = queueWithOneStack.Dequeue();
                Console.WriteLine("Removed Item is: {0}", front);
                Console.WriteLine();

                #endregion

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
