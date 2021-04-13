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
                tail = previous;
                tail.next = null;
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

        public int FindNodeIndex(int item)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("List is empty");
            }

            int index = 0;
            var current = head;

            while (current != null)
            {
                if (current.value == item)
                    return index;

                current = current.next;
                index++;
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
                    var nodetodelete = head;
                    head = head.next;
                    nodetodelete = null;
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
                else
                {
                    while (current.next != null)
                    {
                        if (current.next.value == value)
                        {
                            previousToLast = current;
                            lastNode = current.next;
                        }

                        current = current.next;
                    }
                }

                if (lastNode != null)
                {
                    if (lastNode == head)
                    {
                        head = head.next;
                        lastNode = null;
                    }
                    else
                    {
                        previousToLast.next = lastNode.next;
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

                while (current != null)
                {
                    var next = current.next;
                    current.next = previous;

                    previous = current;
                    current = next;
                }

                tail = head;
                tail.next = null;
                head = previous;
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
                    throw new ArgumentException("Node not exists at given position");;
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
