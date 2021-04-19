using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class DynamicArray
    {
        #region private fileds
        private int[] items;
        private int count;
        #endregion

        #region constructor
        public DynamicArray(int length)
        {
            items = new int[length];
        }
        #endregion

        #region public methods
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void Insert(int item)
        {
            ResizeIfRequired();

            items[count] = item;

            count++;
        }

        public void RemoveAt(int index)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Array is empty");
            }

            if (index < -1 || index >= count)
            {
                throw new ArgumentException();
            }

            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public int Max()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Array is empty");
            }

            int maximum = items[0];

            for (int i = 1; i < count; i++)
            {
                if (items[i] > maximum)
                {
                    maximum = items[i];
                }
            }
            return maximum;
        }

        public int Min()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Array is empty");
            }

            int minimum = items[0];

            for (int i = 1; i < count; i++)
            {
                if (items[i] < minimum)
                {
                    minimum = items[i];
                }
            }
            return minimum;
        }

        public DynamicArray Intersect(DynamicArray anotherArray)
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Array is empty");
            }

            DynamicArray newArray = new DynamicArray(count);

            for (int i = 0; i < anotherArray.count; i++)
            {
                if (IndexOf(anotherArray.items[i]) > -1)
                {
                    newArray.Insert(anotherArray.items[i]);
                }
            }

            return newArray;
        }

        public void Reverse()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Array is empty");
            }

            DynamicArray reverseArray = new DynamicArray(count);

            for (int i = count - 1; i > -1; i--)
            {
                reverseArray.Insert(items[i]);
            }

            items = reverseArray.items;
        }

        public void InsertAt(int item, int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentException();
            }

            ResizeIfRequired();

            for (int i = count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }

            items[index] = item;

            count++;
        }
        #endregion

        #region private methods
        private bool IsEmpty()
        {
            return count <= 0;
        }

        private void ResizeIfRequired()
        {
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }
        }
        #endregion
    }
}
