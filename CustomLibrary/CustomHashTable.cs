using System;
using System.Collections.Generic;
using System.Collections;

namespace CustomLibrary
{
    public class CustomHashTable
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
        public CustomHashTable(int capacity)
        {
            this.entries = new LinkedList<Entry>[5];
        }
        #endregion

        #region public methods
        public void Add(int key, string value)
        {
            var index = hash(key);
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
            var index = hash(key);
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
            var index = hash(key);
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
        private int hash(int key)
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
}
