using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CustomStackLinkedList<T>
    {
        #region private fileds
        private class Node<T>
        {
            public T value;
            public Node<T> next;

            public Node(T value)
            {
                this.value = value;
            }
        }

        private Node<T> head;
        private Node<T> tail;
        private int size;
        private int count;
        #endregion

        #region constructor
        public CustomStackLinkedList(int size)
        {
            this.size = size;
        }
        #endregion

        #region public methods
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            
            if(count == size)
            {
                throw new StackOverflowException("Stack is overflow");
            }

            if(head == null)
            {
                head = tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }

            count++;
        }

        public void Print()
        {
            var current = head;

            while(current !=null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        public T Pop()
        {
            if(count == 0)
            {
                throw new StackOverflowException("Stack is under flow");
            }

            T result = head.value;
            var temp = head;
            head = head.next;
            temp = null;
            count--;

            return result;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new StackOverflowException("Stack is under flow");
            }

            return head.value;
        }
        #endregion
    }
}
