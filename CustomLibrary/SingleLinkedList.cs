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
                else if (position == 1)
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

                    if (current != null)
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

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                var second = head.next;
                head.next = null;
                head = second;
            }

            length--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                var previous = GetPreviousNode(tail);
                tail = previous;
                tail.next = null;
            }

            length--;
        }

        public void RemoveAt(int position)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                if (position < 1)
                {
                    throw new ArgumentException("Position should be >= 1");
                }
                else if (position == 1)
                {
                    var second = head.next;
                    head.next = null;
                    head = second;
                    length--;
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

                    if (current != null && current.next != null)
                    {
                        var nodeToDelete = current.next;
                        current.next = current.next.next;
                        nodeToDelete = null;
                        length--;
                    }
                    else
                    {
                        Console.WriteLine("The node is already null.");
                    }
                }
            }
        }

        public void RemoveAll()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                while (head != null)
                {
                    var temp = head;
                    head = head.next;
                    temp = null;
                }

                length = 0;
                Console.WriteLine("All nodes are deleted successfully.");
            }
        }

        public void RemoveEvenNodes()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (head == tail)
            {
                Console.WriteLine("Linked List should contains ateast 2 nodes");
            }
            else
            {
                var oddNode = head;
                var evenNode = head.next;

                while (oddNode != null && evenNode != null)
                {
                    oddNode.next = evenNode.next;
                    evenNode = null;

                    oddNode = oddNode.next;

                    if (oddNode != null)
                        evenNode = oddNode.next;

                    length--;
                }
            }
        }

        public void RemoveOddNodes()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (head == tail)
            {
                head = tail = null;
                length--;
            }
            else
            {
                var temp = head;
                head = head.next;
                temp = null;
                length--;

                var evenNode = head;
                var oddNode = head.next;

                while (oddNode != null && evenNode != null)
                {
                    evenNode.next = oddNode.next;
                    oddNode = null;

                    evenNode = evenNode.next;

                    if (evenNode != null)
                        oddNode = evenNode.next;

                    length--;
                }
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
