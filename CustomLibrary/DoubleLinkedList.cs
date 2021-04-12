using System;

namespace CustomLibrary
{
    public class DoubleLinkedList
    {
        #region private fileds
        private class Node
        {
            public int value;
            public Node next;
            public Node prev;

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
            var curren = head;

            while (curren != null)
            {
                Console.WriteLine(curren.value);
                curren = curren.next;
            }
        }

        public void AddFirst(int value)
        {
            Node node = new Node(value);

            if (IsEmpty())
            {
                head = tail = node;
            }
            else
            {
                head.prev = node;
                node.next = head;
                head = node;
            }

            length++;
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);

            if (IsEmpty())
            {
                head = tail = node;
            }
            else
            {
                node.prev = tail;
                tail.next = node;
                tail = node;
            }

            length++;
        }

        public void AddAt(int value, int position)
        {
            Node node = new Node(value);

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
                else if (position == 1)
                {
                    head.prev = node;
                    node.next = head;
                    head = node;
                    length++;
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

                    if (current != null)
                    {
                        node.next = current.next;
                        node.prev = current;
                        if (node.next != null)
                        {
                            current.next.prev = node;
                        }
                        current.next = node;
                        length++;
                    }
                    else
                    {
                        Console.WriteLine("The previous node is null.");
                    }
                }
            }
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                var second = head.next;
                head.next = null;
                second.prev = null;
                head = second;
            }

            length--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                var previous = GetPreviousNode(tail);
                previous.next = null;
                tail = previous;
            }

            length--;
        }

        public void RemoveAt(int position)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (position < 1)
            {
                throw new ArgumentException("Position should be >= 1");
            }
            else if (position == 1)
            {
                var second = head.next;
                head.next = null;
                second.prev = null;
                head = second;

                length--;
            }
            else
            {
                var current = head;

                for (int i = 1; i < position-1; i++)
                {
                    if (current != null)
                    {
                        current = current.next;
                    }
                }

                if (current != null && current.next != null)
                {
                    var nodeToDelete = current.next;
                    current.next = current.next.next;
                    if (current.next != null)
                    {
                        current.next.prev = current;
                    }
                    nodeToDelete = null;
                }
                else
                {
                    Console.WriteLine("The node is already null.");
                }

                length--;
            }
        }
        #endregion

        #region private methods
        private bool IsEmpty()
        {
            return head == null;
        }

        private Node GetPreviousNode(Node node)
        {
            var current = head;

            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                current = current.next;
            }

            return null;
        }
        #endregion
    }
}
