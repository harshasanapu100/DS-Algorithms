using System;

namespace CustomLibrary
{
    public class SingleLinkedList
    {
        private class Node
        {
            public int value;
            public Node next;

            Node(int value)
            {
                this.value = value;
            }
        }

        private Node head;
        private Node tail;
        private int length;

        public void Print()
        {
            var current = head;

            while(current!= null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
}
