using System;

namespace CustomLibrary
{
    public class CustomQueueLinkedList
    {
        #region private fields
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        private Node front;
        private Node rear;
        private int length;
        #endregion

        #region public methods
        public void Enqueue(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                front = rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
            }

            length++;
        }

        public int Dequeue()
        {
            int result = -1;

            if (IsEmpty())
            {
                throw new Exception("Queue is underflow");
            }

            if (front == rear)
            {
                result = front.value;
                front = rear = null;
            }
            else
            {
                var temp = front;
                front = front.next;
                result = temp.value;
                temp = null;
            }

            length--;
            return result;
        }

        public int Peek()
        {
            int result = -1;

            if (IsEmpty())
            {
                throw new Exception("Queue is underflow");
            }

            if (front == rear)
            {
                result = front.value;
            }
            else
            {
                result = front.value;
            }

            return result;
        }

        public void Print()
        {
            var current = front;

            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        #endregion

        #region private methods
        private bool IsEmpty()
        {
            return front == null;
        }
        #endregion
    }
}
