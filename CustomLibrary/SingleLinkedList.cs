using System;

namespace CustomLibrary
{
    public class SingleLinkedList
    {
        #region private fields
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node head;
        private Node tail;
        private int length;

        #endregion

        #region public methods
        public void Print()
        {
            var current = head;

            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        public void AddFirst(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                head = tail = node;
            }
            else
            {
                node.next = head;
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
            }
            else
            {
                tail.next = node;
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
            }
            else
            {
                if (position < 1)
                {
                    throw new ArgumentException("Position should be >= 1");
                }
                else if(position == 1)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    var current = head;

                    for (int i = 1; i < position - 1; i++)
                    {

                        if (current != null)
                        {
                            current = current.next;
                        }
                    }

                    if(current!= null)
                    {
                        node.next = current.next;
                        current.next = node;
                    }
                    else
                    {
                        Console.WriteLine("The previous node is null.");
                    }
                }
            }

            length++;
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
