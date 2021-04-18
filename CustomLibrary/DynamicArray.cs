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
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }

            items[count] = item;

            count++;
        }
        #endregion

        #region private methods

        #endregion
    }
}
