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
            var current = head;

            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
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
                var previous = tail.prev;
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

        public void Reverse()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head != tail)
            {
                var current = head;
                Node temp = null;

                while (current != null)
                {
                    temp = current.prev;
                    current.prev = current.next;
                    current.next = temp;
                    current = current.prev;
                }

                if (temp != null)
                {
                    head = temp.prev;
                }
            }
        }

        public void RemoveAll()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            while (head != null)
            {
                var nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
            }

            length = 0;
            Console.WriteLine("All nodes are deleted successfully.");
        }

        public void RemoveEvenNodes()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail)
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

                    if (oddNode.next != null)
                    {
                        oddNode.next.prev = oddNode;
                    }

                    oddNode = oddNode.next;

                    if (oddNode != null)
                    {
                        evenNode = oddNode.next;
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

            if (head == tail)
            {
                head = tail = null;
                length--;
            }
            else
            {
                var temp = head;
                head = head.next;
                head.prev = null;
                temp = null;

                var evenNode = head;
                var oddNode = head.next;

                while (evenNode != null && oddNode != null)
                {
                    evenNode.next = oddNode.next;
                    oddNode = null;

                    if (evenNode.next != null)
                    {
                        evenNode.next.prev = evenNode;
                    }

                    evenNode = evenNode.next;

                    if (evenNode != null)
                    {
                        oddNode = evenNode.next;
                    }

                    length--;
                }
            }
        }

        public void RemoveFirstNodeByValue(int value)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail)
            {
                if (head.value == value)
                {
                    head = tail = null;
                    length--;
                }

            }
            else
            {
                if (head.value == value)
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

                    while (current.next != null)
                    {
                        if (current.next.value == value)
                        {
                            var nodeToDelete = current.next;
                            current.next = current.next.next;
                            if (current.next != null)
                            {
                                current.next.prev = current;
                            }
                            nodeToDelete = null;
                            length--;
                            break;
                        }
                        current = current.next;
                    }
                }
            }
        }

        public void RemoveLastNodeByValue(int value)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail)
            {
                if (head.value == value)
                {
                    head = tail = null;
                    length--;
                }
            }
            else
            {
                Node previousToLast = null, lastNode = null, current = head;

                if (current.value == value)
                {
                    lastNode = current;
                }

                while (current.next != null)
                {
                    if (current.next.value == value)
                    {
                        previousToLast = current;
                        lastNode = current.next;
                    }

                    current = current.next;
                }

                if (lastNode != null)
                {
                    if (lastNode == head)
                    {
                        var nodeToDelete = head;
                        head = head.next;
                        nodeToDelete = null;
                        head.prev = null;
                        lastNode = null;
                    }
                    else
                    {
                        previousToLast.next = lastNode.next;
                        if (previousToLast.next != null)
                        {
                            previousToLast.next.prev = previousToLast;
                        }
                        lastNode = null;
                    }

                    length--;
                }
            }
        }

        public void RemoveAllNodesByValue(int value)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail)
            {
                if (head.value == value)
                {
                    head = tail = null;
                    length--;
                }

            }
            else
            {
                Node nodeToDelete;

                while (head != null && head.value == value)
                {
                    nodeToDelete = head;
                    head = head.next;
                    head.prev = null;
                    nodeToDelete = null;
                    length--;
                }

                var current = head;

                if (current != null)
                {
                    while (current.next != null)
                    {
                        if (current.next.value == value)
                        {
                            nodeToDelete = current.next;
                            current.next = current.next.next;
                            if (current.next != null)
                            {
                                current.next.prev = current;
                            }
                            nodeToDelete = null;
                            length--;
                        }
                        else
                        {
                            current = current.next;
                        }
                    }
                }
            }
        }

        public int GetKthNodeFromEnd(int k)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            var first = head;
            var second = head;

            for (int i = 0; i < k - 1; i++)
            {
                second = second.next;
                if (second == null)
                    throw new ArgumentException("Node not exists at given position");
            }

            while (second != tail)
            {
                first = first.next;
                second = second.next;
            }

            return first.value;
        }

        public void PrintMiddleNode()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            var first = head;
            var second = head;


            while (second != tail && second.next != tail)
            {
                first = first.next;
                second = second.next.next;
            }

            if (second == tail)
                Console.WriteLine(first.value);
            else
                Console.WriteLine(first.value + "," + first.next.value);
        }

        public void RemoveMiddleNode()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head == tail || (head.next == tail && tail.prev== head))
            {
                head = tail = null;
            }
            else
            {
                var first = head;
                var second = head;
                Node previous = null;

                while (second != tail && second.next != tail)
                {
                    first = first.next;
                    previous = first.prev;
                    second = second.next.next;
                }

                if (second == tail)
                {
                    previous.next = first.next;
                    previous.next.prev = first.prev;
                }
                else
                {
                    previous.next = second;
                    previous.next.prev = first.prev;
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
