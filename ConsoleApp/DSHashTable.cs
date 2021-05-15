using System;
using CustomLibrary;

namespace ConsoleApp
{
    class DSHashTable
    {
        static void Main(string[] args)
        {
            try
            {
                #region CustomHashTableUsingChaining
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the hash table contains key as int and value as string with the capacity of 5 elements using chaining");
                Console.ForegroundColor = ConsoleColor.White;
                CustomHashTableUsingChaining customHashTableUsingChaining = new CustomHashTableUsingChaining(5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements to hash table");
                Console.ForegroundColor = ConsoleColor.White;

                customHashTableUsingChaining.Add(0, "Harsha");
                customHashTableUsingChaining.Add(1, "Amar");
                customHashTableUsingChaining.Add(2, "Prudhvi");
                customHashTableUsingChaining.Add(3, "Ashok");
                customHashTableUsingChaining.Add(4, "Raja");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingChaining.Print();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing somemore elements to hash table");
                Console.ForegroundColor = ConsoleColor.White;

                customHashTableUsingChaining.Add(12, "Pavani");
                customHashTableUsingChaining.Add(19, "Pallavi");
                customHashTableUsingChaining.Add(16, "Sravanti");
                customHashTableUsingChaining.Add(15, "Madhavi");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingChaining.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Get the item by key");
                Console.ForegroundColor = ConsoleColor.White;
                string result = customHashTableUsingChaining.Get(2);
                Console.WriteLine("key : {0} value: {1}", 2, result);
                result = customHashTableUsingChaining.Get(19);
                Console.WriteLine("key : {0} value: {1}", 19, result);
                result = customHashTableUsingChaining.Get(4);
                Console.WriteLine("key : {0} value: {1}", 4, result);
                result = customHashTableUsingChaining.Get(7);
                Console.WriteLine("key : {0} value: {1}", 7, result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Remove the item by key");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Removed key is 4");
                customHashTableUsingChaining.Remove(4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingChaining.Print();

                Console.WriteLine();
                Console.WriteLine("Removed key is 15");
                customHashTableUsingChaining.Remove(15);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingChaining.Print();
                #endregion

                #region CharacterFinder
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding First Non Repeated Character");
                Console.ForegroundColor = ConsoleColor.White;

                CharacterFinder characterFinder = new CharacterFinder();
                string input = "a green apple";
                char output = characterFinder.FindFirstNonRepeatedCharacter(input);
                Console.WriteLine("input: {0}", input);
                Console.WriteLine("output: {0}", output);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding First Repeated Character");
                Console.ForegroundColor = ConsoleColor.White;

                input = "a green apple";
                output = characterFinder.FindFirstRepeatedCharacter(input);
                Console.WriteLine("input: {0}", input);
                Console.WriteLine("output: {0}", output);
                #endregion

                #region MostFrequentFinder
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding most frequented item in array");
                Console.ForegroundColor = ConsoleColor.White;

                MostFrequentFinder mostFrequentFinder = new MostFrequentFinder(8);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 10, 20, 10, 20, 40, 10, 20, 20 elements to array");
                mostFrequentFinder.items[0] = 10;
                mostFrequentFinder.items[1] = 20;
                mostFrequentFinder.items[2] = 30;
                mostFrequentFinder.items[3] = 20;
                mostFrequentFinder.items[4] = 40;
                mostFrequentFinder.items[5] = 10;
                mostFrequentFinder.items[6] = 20;
                mostFrequentFinder.items[7] = 20;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                int value = mostFrequentFinder.FindMostFrequentElement();
                Console.WriteLine("Most frequented element in the array is: {0}", value);
                #endregion

                #region PairsWithDiff
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Count the pairs with the given difference");
                Console.ForegroundColor = ConsoleColor.White;

                PairsWithDiff pairsWithDiff = new PairsWithDiff(7);
                int difference = 2;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Difference is: {0}", difference);
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the 1, 7, 5, 9, 2, 12, 3 elements to array");
                pairsWithDiff.items[0] = 1;
                pairsWithDiff.items[1] = 7;
                pairsWithDiff.items[2] = 5;
                pairsWithDiff.items[3] = 9;
                pairsWithDiff.items[4] = 2;
                pairsWithDiff.items[5] = 12;
                pairsWithDiff.items[6] = 3;
                Console.ForegroundColor = ConsoleColor.White;

                value = pairsWithDiff.CountPairsWithDiff(difference);
                Console.WriteLine("Total pairs with the given difference {0} is {1}", difference, value);
                #endregion

                #region CustomHashTableUsingLinearProbing
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the hash table contains key as int and value as string with the capacity of 5 elements using chaining");
                Console.ForegroundColor = ConsoleColor.White;
                CustomHashTableUsingLinearProbing customHashTableUsingLinearProbing = new CustomHashTableUsingLinearProbing(5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements to hash table");
                Console.ForegroundColor = ConsoleColor.White;

                customHashTableUsingLinearProbing.Add(0, "Harsha");
                customHashTableUsingLinearProbing.Add(1, "Amar");
                customHashTableUsingLinearProbing.Add(2, "Prudhvi");
                customHashTableUsingLinearProbing.Add(3, "Ashok");
                customHashTableUsingLinearProbing.Add(4, "Raja");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingLinearProbing.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Get the item by key");
                Console.ForegroundColor = ConsoleColor.White;
                result = customHashTableUsingLinearProbing.Get(2);
                Console.WriteLine("key : {0} value: {1}", 2, result);
                result = customHashTableUsingLinearProbing.Get(3);
                Console.WriteLine("key : {0} value: {1}", 3, result);
                result = customHashTableUsingLinearProbing.Get(4);
                Console.WriteLine("key : {0} value: {1}", 4, result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Remove the item by key");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Removed key is 4");
                customHashTableUsingLinearProbing.Remove(4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingLinearProbing.Print();

                Console.WriteLine();
                Console.WriteLine("Removed key is 2");
                customHashTableUsingLinearProbing.Remove(2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements");
                Console.ForegroundColor = ConsoleColor.White;
                customHashTableUsingLinearProbing.Print();
                #endregion

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
