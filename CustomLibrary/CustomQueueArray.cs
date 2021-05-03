using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CustomQueueArray
    {
        #region private fileds
        private int[] items;
        private int front;
        private int rear;
        private int count;
        private int incr;
        #endregion

        #region constructor
        public CustomQueueArray(int length)
        {
            this.items = new int[length];
        }
        #endregion

        #region public methods
        public void Enqueue(int item)
        {
            if (count == items.Length)
            {
                throw new Exception("Queue is overflow");
            }

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            incr++;
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
            {
                throw new Exception("Queue is underflow");
            }

            var item = items[front];
            front = (front + 1) % items.Length;
            count--;

            return item;
        }

        public void Print()
        {
            int max = incr >= items.Length ? items.Length:rear;

            for (int i = front; i < max; i++)
            {
                Console.WriteLine(items[i]);
            }

            if (incr >= items.Length)
            {
                for (int i = incr - items.Length; i > 0; i--)
                {
                    Console.WriteLine(items[i - 1]);
                }
            }

        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new Exception("Queue is underflow");
            }

            return items[front];
        }
        #endregion
    }

    public class ReverseQueue
    {
        Stack<int> stack = new Stack<int>();
        public Queue<int> Reverse(Queue<int> queue)
        {
            while (queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count != 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

    }
}