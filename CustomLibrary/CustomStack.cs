using System;
using System.Collections;
using System.Text;

namespace CustomLibrary
{
    public class CustomStack
    {
        #region private fields
        private int[] items;
        private int count;
        #endregion

        #region constructor
        public CustomStack(int length)
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
        #endregion
    }
}
