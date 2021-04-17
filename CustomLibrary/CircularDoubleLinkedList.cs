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

            Node(int value)
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
        #endregion

        #region private methods
        private bool IsEmpty()
        {
            return head == null;
        }
        #endregion
    }
}
