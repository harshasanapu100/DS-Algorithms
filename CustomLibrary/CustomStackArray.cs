using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CustomStackArray
    {
        #region private fields
        private int[] items;
        private int count;
        #endregion

        #region constructor
        public CustomStackArray(int length)
        {
            items = new int[length];
        }
        #endregion

        #region public methods
        public void Push(int item)
        {
            if (count == items.Length)
            {
                throw new StackOverflowException("Stack is overflow");
            }

            items[count] = item;
            count++;
        }

        public int Pop()
        {
            if (count == 0)
            {
                throw new StackOverflowException("Stack is underflow");
            }

            count--;
            return items[count];
        }

        public void Print()
        {
            if (count == 0)
            {
                throw new StackOverflowException("Stack is underflow");
            }

            for (int i = count - 1; i > -1; i--)
            {
                Console.WriteLine(items[i]);
            }
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[count - 1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public string Reverse(string input)
        {
            StringBuilder builder = new StringBuilder();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                builder.Append(stack.Pop());
            }

            return builder.ToString();
        }
        #endregion
    }
}
