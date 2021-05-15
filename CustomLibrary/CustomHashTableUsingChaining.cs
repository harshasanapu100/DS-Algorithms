using System;
using System.Collections.Generic;

namespace CustomLibrary
{
    public class CustomHashTableUsingChaining
    {
        #region private fileds
        private class Entry
        {
            public int key;
            public string value;
            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] entries;
        #endregion

        #region constructor
        public CustomHashTableUsingChaining(int capacity)
        {
            this.entries = new LinkedList<Entry>[5];
        }
        #endregion

        #region public methods
        public void Add(int key, string value)
        {
            var index = Hash(key);
            if (entries[index] == null)
            {
                entries[index] = new LinkedList<Entry>();
            }

            var bucket = entries[index];
            foreach (Entry entry in bucket)
            {
                if (entry.key == key)
                {
                    throw new Exception("Key already exists");
                }
            }

            entries[index].AddLast(new Entry(key, value));
        }

        public string Get(int key)
        {
            var index = Hash(key);
            var bucket = entries[index];

            if (bucket != null)
            {
                foreach (Entry entry in bucket)
                {
                    if (entry.key == key)
                    {
                        return entry.value;
                    }
                }
            }

            return null;
        }

        public void Remove(int key)
        {
            var index = Hash(key);
            var bucket = entries[index];

            if (bucket == null)
            {
                throw new Exception("Key is not exists");
            }

            foreach (Entry entry in bucket)
            {
                if (entry.key == key)
                {
                    bucket.Remove(entry);
                    return;
                }
            }

            throw new Exception("Key is not exists");
        }

        public void Print()
        {
            foreach (LinkedList<Entry> listEntry in entries)
            {
                if (listEntry != null)
                {
                    foreach (Entry entry in listEntry)
                    {
                        Console.Write(entry.key + " " + entry.value + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        #endregion

        #region private methods
        private int Hash(int key)
        {
            return key % entries.Length;
        }

        #endregion
    }

    public class CharacterFinder
    {
        public char FindFirstNonRepeatedCharacter(string input)
        {
            char[] chars = input.ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (char ch in chars)
            {
                var count = keyValuePairs.ContainsKey(ch) ? keyValuePairs[ch] : 0;

                if (count == 0)
                {
                    keyValuePairs.Add(ch, count + 1);
                }
                else
                {
                    keyValuePairs[ch] = count + 1;
                }
            }

            foreach (KeyValuePair<char, int> keyValuePair in keyValuePairs)
            {
                if (keyValuePair.Value == 1)
                {
                    return keyValuePair.Key;
                }
            }

            return char.MinValue;
        }

        public char FindFirstRepeatedCharacter(string input)
        {
            char[] chars = input.ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (char ch in chars)
            {
                var count = keyValuePairs.ContainsKey(ch) ? keyValuePairs[ch] : 0;

                if (count == 0)
                {
                    keyValuePairs.Add(ch, count + 1);
                }
                else
                {
                    return ch;
                }
            }

            return char.MinValue;
        }
    }

    public class MostFrequentFinder
    {
        public int[] items;
        public MostFrequentFinder(int capacity)
        {
            this.items = new int[capacity];
        }
        public int FindMostFrequentElement()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int max = -1;
            int result = items[0];

            foreach (int item in items)
            {
                var count = keyValuePairs.ContainsKey(item) ? keyValuePairs[item] : 0;
                if (count == 0)
                {
                    keyValuePairs.Add(item, count + 1);
                }
                else
                {
                    keyValuePairs[item] = count + 1;
                }
            }

            foreach (KeyValuePair<int, int> keyValuePair in keyValuePairs)
            {
                if (keyValuePair.Value > max)
                {
                    max = keyValuePair.Value;
                    result = keyValuePair.Key;
                }
            }

            return result;
        }
    }

    public class PairsWithDiff
    {
        public int[] items;
        public PairsWithDiff(int capacity)
        {
            this.items = new int[capacity];
        }

        public int CountPairsWithDiff(int difference)
        {
            HashSet<int> hashSet = new HashSet<int>();
            int count = 0;

            foreach (int item in items)
            {
                hashSet.Add(item);
            }

            foreach (int item in items)
            {
                if (hashSet.Contains(item + difference))
                {
                    count++;
                }

                if (hashSet.Contains(item - difference))
                {
                    count++;
                }

                hashSet.Remove(item);
            }

            return count;
        }
    }

    public class IndicesOfTwoNumbersWithTargetSum
    {
        public int[] items;
        public IndicesOfTwoNumbersWithTargetSum(int capacity)
        {
            this.items = new int[capacity];
        }

        public void GetIndicesOfTwoNumbersWithTargetSum(int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < items.Length; i++)
            {
                int complement = target - items[i];
                if (keyValuePairs.ContainsKey(complement))
                {
                    Console.WriteLine(keyValuePairs[complement] + " " + i);
                }
                keyValuePairs.Add(items[i], i);
            }
        }
    }

    public class CustomHashTableUsingLinearProbing
    {
        #region private fileds
        private class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }
        private Entry[] entries;
        private int count;
        #endregion

        #region constructor
        public CustomHashTableUsingLinearProbing(int capacity)
        {
            this.entries = new Entry[capacity];
        }
        #endregion

        #region public methods
        public void Add(int key, string value)
        {
            var entry = GetEntry(key);
            if (entry != null)
            {
                throw new Exception("Key already exists");
            }

            if (IsFull())
            {
                throw new Exception("Hash table is overflow");
            }

            entries[GetIndex(key)] = new Entry(key, value);
            count++;
        }

        public string Get(int key)
        {
            var entry = GetEntry(key);
            return entry != null ? entry.value : null;
        }

        public void Remove(int key)
        {
            var index = GetIndex(key);
            if (index == -1 || entries[index] == null)
            {
                return;
            }

            entries[index] = null;
            count--;
        }

        public void Print()
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] != null)
                {
                    Console.WriteLine(entries[i].key + " " + entries[i].value);
                }
                else
                {
                    count = count - 1;
                }
            }
        }
        #endregion

        #region private methods

        private Entry GetEntry(int key)
        {
            var index = GetIndex(key);
            return index >= 0 ? entries[index] : null;
        }

        private int GetIndex(int key)
        {
            int steps = 0;
            while (steps < entries.Length)
            {
                int index = Index(key, steps++);
                var entry = entries[index];
                if (entry == null || entry.key == key)
                {
                    return index;
                }
            }

            return -1;
        }

        private int Index(int key, int i)
        {
            return (Hash(key) + i) % entries.Length;
        }

        private int Hash(int key)
        {
            return key % entries.Length;
        }

        private bool IsFull()
        {
            return count == entries.Length;
        }
        #endregion
    }
}
