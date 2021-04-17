using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CircularDoubleLinkedList
    {
        #region private fields
        private class Node
        {
            public int value;
            public Node prev;
            public Node next;

            public Node(int value)
            {
                this.value = value;
                this.prev = null;
                this.next = null;
            }
        }

        private Node head;
        private Node tail;
        public int length;
        #endregion

        #region public methods
        public void Print()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            var current = head;

            while (true)
            {
                Console.WriteLine(current.value);
                current = current.next;

                if (current == head)
                {
                    break;
                }
            }
        }

        public void AddFirst(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                head = tail = node;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                node.next = head;
                head.prev = node;
                head = node;
            }

            length++;
        }

        public void AddLast(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                head = tail = node;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                node.next = head;
                head.prev = node;
                tail = node;
            }

            length++;
        }

        public void AddAt(int item, int position)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                head = tail = node;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
            }
            else
            {
                if (position < 1 || position > length + 1)
                {
                    throw new ArgumentException("Invalid position to add the node.");
                }
                else if (position == 1)
                {
                    tail.next = node;
                    node.prev = tail;
                    node.next = head;
                    head.prev = node;
                    head = node;

                    length++;
                }
                else
                {
                    var current = head;

                    for (int i = 1; i < position - 1; i++)
                    {
                        current = current.next;
                    }

                    node.next = current.next;
                    current.next.prev = node;

                    current.next = node;
                    node.prev = current;

                    if(position == length + 1)
                    {
                        tail = node;
                        tail.next = head;
                        head.prev = tail;
                    }

                    length++;
                }
            }
        }
        #endregion

        #region private methods
        private bool IsEmpty()
        {
            return head == null;
        }
        #endregion
    }
}
