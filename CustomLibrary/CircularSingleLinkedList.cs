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

            if (position < 1 || position > length)
            {
                throw new ArgumentException("Invalid position to remove the node.");
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

                    if (oddNode.next != head)
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
                        tail.next = head;
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

                    if (evenNode.next != head)
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
                        tail.next = head;
                    }

                    length--;
                }
            }
        }

        public int FindNodeIndex(int item)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            int index = 1;
            var current = head;

            while (true)
            {
                if (current.value == item)
                {
                    return index;
                }
                index++;
                current = current.next;

                if (current == head)
                {
                    break;
                }
            }

            return -1;
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
                    var nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;
                    tail.next = head;

                    length--;
                }
                else
                {
                    var current = head;

                    while (current.next != head)
                    {
                        if (current.next.value == value)
                        {
                            var nodeToDelete = current.next;
                            current.next = current.next.next;
                            nodeToDelete = null;
                            length--;

                            if (current.next == head)
                            {
                                tail = current;
                                tail.next = head;
                            }
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

                while (current.next != head)
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
                        head = head.next;
                        lastNode = null;
                        tail.next = head;
                        length--;
                    }
                    else
                    {
                        previousToLast.next = lastNode.next;
                        lastNode = null;
                        length--;

                        if (previousToLast.next == head)
                        {
                            tail = previousToLast;
                            tail.next = head;
                        }
                    }
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
                    if (head.next == head)
                    {
                        head = null;
                        length--;
                    }
                    else
                    {
                        nodeToDelete = head;
                        head = head.next;
                        nodeToDelete = null;
                        tail.next = head;
                        length--;
                    }
                }

                var current = head;

                while (current.next != head)
                {
                    if (current.next.value == value)
                    {
                        nodeToDelete = current.next;
                        current.next = current.next.next;
                        nodeToDelete = null;
                        length--;

                        if (current.next == head)
                        {
                            tail = current;
                            tail.next = head;
                        }
                    }

                    current = current.next;
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

                if (second == head)
                {
                    throw new ArgumentException("Node not exists at given position");
                }
            }

            while (second != tail)
            {
                first = first.next;
                second = second.next;
            }

            return first.value;
        }

        public void RemoveAll()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            var temp = head;
            while (head.next != temp)
            {
                var nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
            }

            head.next = null;
            head = tail = null;
            length = 0;

            Console.WriteLine("All nodes are deleted successfully.");
        }

        public void Reverse()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            if (head != tail)
            {
                var previous = head;
                var current = head.next;

                while (current != head)
                {
                    var next = current.next;
                    current.next = previous;

                    previous = current;
                    current = next;
                }

                tail = head;
                head = previous;
                tail.next = head;
            }
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
            {
                Console.WriteLine(first.value);
            }
            else
            {
                Console.WriteLine(first.value + " " + first.next.value);
            }
        }

        public void RemoveMiddleNode()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            var first = head;
            var second = head;
            Node previous = null;

            while (second != tail && second.next != tail)
            {
                previous = first;
                first = first.next;
                second = second.next.next;
            }

            if (second == tail)
            {
                previous.next = first.next;
                length--;
            }
            else
            {
                if (previous == null)
                {
                    head = tail = null;
                }
                else
                {
                    previous.next = second;
                }
                length = length - 2;
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
