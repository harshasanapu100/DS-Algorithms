using System;

namespace CustomLibrary
{
    public class CircularSingleLinkedList
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

            while (true)
            {
                Console.WriteLine(current.value);
                current = current.next;

                if (current == head)
                    break;
            }
        }

        public void AddFirst(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                head = tail = node;
                tail.next = head;
            }
            else
            {
                node.next = head;
                head = node;
                tail.next = head;
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
            }
            else
            {
                tail.next = node;
                tail = node;
                tail.next = head;
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
                if (position < 1 || position > length + 1)
                {
                    throw new ArgumentException("Invalid position to add the node.");
                }
                else if (position == 1)
                {
                    node.next = head;
                    head = node;
                    tail.next = head;

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
                    current.next = node;

                    if (position == length + 1)
                    {
                        tail = node;
                        tail.next = head;
                    }

                    length++;
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
                length--;
            }
            else
            {
                var second = head.next;
                head.next = null;
                head = second;
                tail.next = head;

                length--;
            }
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
                length--;
            }
            else
            {
                var previous = GetPrevious(tail);
                tail = previous;
                tail.next = head;

                length--;
            }
        }

        public void RemoveAt(int position)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }
            else
            {
                if (position < 1 || position > length)
                {
                    throw new ArgumentException("Invalid position to delete the node.");
                }
                else if (position == 1)
                {
                    var nodeToDelete = head;
                    head = head.next;
                    tail.next = head;
                    nodeToDelete = null;

                    length--;
                }
                else
                {
                    var current = head;

                    for (int i = 1; i < position - 1; i++)
                    {
                        current = current.next;
                    }

                    var nodeToDelete = current.next;
                    current.next = current.next.next;
                    nodeToDelete = null;

                    if (position == length)
                    {
                        tail = current;
                        tail.next = head;
                    }

                    length--;
                }
            }
        }

        public void RemoveEvenNodes()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }
            else if (head == tail)
            {
                Console.WriteLine("List should contains ateast 2 nodes");
            }
            else
            {
                var oddNode = head;
                var evenNode = head.next;

                while (oddNode != null && evenNode != null)
                {
                    oddNode.next = evenNode.next;
                    evenNode = null;

                    if (oddNode != null && oddNode.next != head)
                    {
                        oddNode = oddNode.next;

                        if (oddNode.next != head)
                        {
                            evenNode = oddNode.next;
                        }
                    }
                    else
                    {
                        tail = oddNode;
                    }

                    length--;
                }
            }
        }

        public void RemoveOddNodes()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }
            else if (head == tail)
            {
                head = tail = null;
                length--;
            }
            else
            {
                var nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
                tail.next = head;
                length--;

                var evenNode = head;
                var oddNode = head.next;

                while (evenNode != null && oddNode != null)
                {
                    evenNode.next = oddNode.next;
                    oddNode = null;

                    if (evenNode != null && evenNode.next != head)
                    {
                        evenNode = evenNode.next;

                        if (evenNode.next != head)
                        {
                            oddNode = evenNode.next;
                        }
                    }
                    else
                    {
                        tail = evenNode;
                       
                    }

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

        private Node GetPrevious(Node node)
        {
            var current = head;

            while (current != null)
            {
                if (current.next.value == node.value)
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
