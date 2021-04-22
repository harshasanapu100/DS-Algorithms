using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CustomLibrary
{
    public class CustomStackArray<T>
    {
        #region private fields
        private T[] items;
        private int count;
        #endregion

        #region constructor
        public CustomStackArray(int length)
        {
            items = new T[length];
        }
        #endregion

        #region public methods
        public void Push(T item)
        {
            if (count == items.Length)
            {
                throw new StackOverflowException("Stack is overflow");
            }

            items[count] = item;
            count++;
        }

        public T Pop()
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

        public T Peek()
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

        public bool IsExpressionBalanced(string expression)
        {
            CustomStackArray<char> customStackLinkedList = new CustomStackArray<char>(expression.Length);

            foreach (char ch in expression)
            {
                if (isLeftBracket(ch))
                {
                    customStackLinkedList.Push(ch);
                }

                if (isRightBracket(ch))
                {
                    if (customStackLinkedList.IsEmpty())
                    {
                        return false;
                    }

                    var top = customStackLinkedList.Pop();

                    if (!isBracketsMatched(top, ch))
                        return false;
                }
            }

            return customStackLinkedList.IsEmpty();
        }
        #endregion

        #region private methods
        private bool isLeftBracket(char ch)
        {
            return ch == '(' || ch == '<' || ch == '[' || ch == '{';
        }

        private bool isRightBracket(char ch)
        {
            return ch == ')' || ch == '>' || ch == ']' || ch == '}';
        }

        private bool isBracketsMatched(char left, char right)
        {
            return (right == ')' && left == '(' ||
                right == '>' && left == '<' ||
                right == ']' && left == '[' ||
                right == '}' && left == '{');
        }
        #endregion
    }
}
