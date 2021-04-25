using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CustomStackArray<T>
    {
        #region private fields
        private T[] items;
        private int top = -1;
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
            if (top + 1 == items.Length)
            {
                throw new StackOverflowException("Stack is overflow");
            }

            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[top--];
        }

        public void Print()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine(items[i]);
            }
        }

        public T Peek()
        {
            if (top == -1)
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
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

        public bool IsExpressionHaveDuplicateBraces(string expression)
        {
            CustomStackArray<char> customStackLinkedList = new CustomStackArray<char>(expression.Length);

            foreach (char ch in expression)
            {
                if (ch != ')')
                {
                    customStackLinkedList.Push(ch);
                }
                else
                {
                    if (customStackLinkedList.Peek() == '(')
                    {
                        return true;
                    }

                    while (customStackLinkedList.Peek() != '(')
                    {
                        customStackLinkedList.Pop();
                    }

                    customStackLinkedList.Pop();
                }
            }

            return false;
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

    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();

        public void Push(int item)
        {
            stack.Push(item);

            if (minStack.Count == 0)
            {
                minStack.Push(item);
            }
            else if (item < minStack.Peek())
            {
                minStack.Push(item);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                throw new StackOverflowException("Stack is underflow");
            }

            var top = stack.Pop();

            if (minStack.Peek() == top)
            {
                minStack.Pop();
            }

            return top;
        }

        public int Min()
        {
            return minStack.Peek();
        }
    }

    public class TwoStacks<T>
    {
        #region private fileds
        private T[] items;
        private int top1;
        private int top2;
        #endregion

        #region constructor
        public TwoStacks(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length must be 1 or greater.");
            }

            top1 = -1;
            top2 = length;
            items = new T[length];
        }
        #endregion

        #region public methods
        public void Push1(T item)
        {
            if (IsFull1())
            {
                throw new StackOverflowException("Stack is overflow");
            }

            items[++top1] = item;
        }

        public T Pop1()
        {
            if (IsEmpty1())
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[top1--];
        }

        public T Peek1()
        {
            if (IsEmpty1())
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[top1];
        }

        public void Push2(T item)
        {
            if (IsFull2())
            {
                throw new StackOverflowException("Stack is overflow");
            }

            items[--top2] = item;
        }

        public T Pop2()
        {
            if (IsEmpty2())
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[top2++];
        }

        public T Peek2()
        {
            if (IsEmpty2())
            {
                throw new StackOverflowException("Stack is underflow");
            }

            return items[top2];
        }

        public void Print()
        {
            for (int i = items.Length - 1; i > -1; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
        #endregion

        #region private methods
        private bool IsFull1()
        {
            return top1 == top2 - 1;
        }

        private bool IsEmpty1()
        {
            return top1 == -1;
        }

        private bool IsFull2()
        {
            return top2 == top1 + 1;
        }

        private bool IsEmpty2()
        {
            return top2 == items.Length;
        }
        #endregion
    }

    public class StackReverse
    {
        public Stack<int> stack = new Stack<int>();

        public void Reverse()
        {
            if (stack.Count > 0)
            {
                int top = stack.Peek();
                stack.Pop();
                Reverse();
                InsetAtBottom(top);
            }
        }

        public void InsetAtBottom(int item)
        {
            if (stack.Count == 0)
            {
                stack.Push(item);
            }
            else
            {
                int top = stack.Peek();
                stack.Pop();
                InsetAtBottom(item);
                stack.Push(top);
            }
        }

        public void Print()
        {
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
