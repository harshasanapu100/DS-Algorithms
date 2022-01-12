using System;

namespace ConsoleApp
{
    class SampleArray
    {
        static void SampleArrayMain(string[] args)
        {
            #region  Single dimensional array
            // First way - 
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Second way
            int[] evenNumbers = new int[5] { 2, 4, 6, 8, 10 };

            // Third way
            int[] oddNumbers = { 1, 3, 5, 7, 9 };
            #endregion

            #region  Array class methods
            string[] countries = { "India", "Pakistan", "Australia", "England", "South Africa" };

            Console.WriteLine(countries); //System.String[]
            Console.WriteLine(countries.GetType().Name); //String[]

            //Length
            Console.WriteLine("Length: " + countries.Length);

            //IndexOf
            int index = Array.IndexOf(countries, "England");
            Console.WriteLine("England index: " + index);

            //Clear
            Array.Clear(countries, 3, 1);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Effect of Clear():");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string item in countries)
            {
                Console.WriteLine(item);
            }

            //Copy
            string[] newCountries = new string[2];
            Array.Copy(countries, newCountries, 2);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Effect of Copy():");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string item in newCountries)
            {
                Console.WriteLine(item);
            }

            //Sort
            Array.Sort(countries);
            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Effect of Sort():");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string item in countries)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Array.Reverse(newCountries);
            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Effect of Reverse():");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string item in newCountries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            #endregion

            #region  Multi dimensional array

            #region Rectanuglar array - Each row in array contains same no of columns
            // 2D array
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Two dimensional array with 2 rows 3 columns");
            Console.ForegroundColor = ConsoleColor.White;
            int[,] evenNumbers2D = new int[2, 3];
            evenNumbers2D[0, 0] = 2;
            evenNumbers2D[0, 1] = 4;
            evenNumbers2D[0, 2] = 6;
            evenNumbers2D[1, 0] = 8;
            evenNumbers2D[1, 1] = 10;
            evenNumbers2D[1, 2] = 12;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(evenNumbers2D[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Two dimensional array with 3 rows 3 columns");
            Console.ForegroundColor = ConsoleColor.White;
            string[,] countryPlayers = new string[3, 3]
                                           {
                                                { "Sachin", "Sehwag", "Dhoni" },
                                                {"Ponting", "Hayden", "Warne" },
                                                {"Lara","Gayle","Samules" }
                                           };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t\t", countryPlayers[i, j]);
                }
                Console.WriteLine();
            }

            //3D Array
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Three dimensional array with one row of two-dimensional array [2, 2]");
            Console.ForegroundColor = ConsoleColor.White;
            string[,,] regions = new string[1, 2, 2];
            regions[0, 0, 0] = "South";
            regions[0, 0, 1] = "East";
            regions[0, 1, 0] = "West";
            regions[0, 1, 1] = "North";

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write(regions[i, j, k]);
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Three dimensional array with  two rows of two-dimensional array [2, 3]");
            Console.ForegroundColor = ConsoleColor.White;
            string[,,] alphabets = new string[2, 2, 3]
            {
                {
                    {"A","B","C" },
                    {"D","E","F" }
                },

                {
                    {"G","H","I" },
                    {"J","K","L" }
                },
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(alphabets[i, j, k]);
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
            }

            #endregion

            #region Jagged Array - Each row in array contains different no of columns
            // Creating jagged array to store qualifications of an employee
            // each employee can have different no of qualifications
            string[][] jaggedArray = new string[3][];
            string[] employees = { "Harsha", "Ashok", "Amar" };
            jaggedArray[0] = new string[3] { "Bachelor", "Master", "Doctorate" };
            jaggedArray[1] = new string[1] { "Master" };
            jaggedArray[2] = new string[2] { "Bachelor", "Doctorate" };

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jagged Array Example");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine(employees[i]);
                Console.WriteLine("=======");
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }

                Console.WriteLine();
            }

            #endregion

            #endregion
        }
    }
}
