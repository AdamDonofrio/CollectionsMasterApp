using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //Console.WriteLine("Random as Random");
            Populater(numArray);


            //TODO: Print the first number of the array
            Console.WriteLine(numArray[0]);

            //TODO: Print the last number of the array
            Console.WriteLine(numArray[numArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            //  1) First way, using a custom method => Hint: Array._____(); 
            //    2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            
            

            Console.WriteLine("All Numbers Reversed:");

            ReverseArray(numArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            //      Hint: Array.____()      
            Console.WriteLine("Sorted numbers:");

            SortArray(numArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> intList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {intList.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList, 50);

            //TODO: Print the new capacity
            Console.WriteLine($"Capacity: {intList.Count}");

            Console.WriteLine("---------------------");

            //NumberPrinter(intList);
            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userNumber = Convert.ToInt32(Console.ReadLine()); // ****************************************************

            //Console.WriteLine(userNumber);
            NumberChecker(intList, userNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            NumberPrinter(OddKiller(intList));


            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            ListSorter(OddKiller(intList));
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] ListArray = new int[intList.Count];
            ListArray = ListToArray(intList);
            
            //NumberPrinter(ListArray);

            //TODO: Clear the list
            intList.Clear();

            #endregion
        }

        private static int[] ListToArray(List<int> intList)
        {

            return intList.ToArray();
        }

        private static void ListSorter(List<int> intList)
        {
            intList.Sort();  
            
            NumberPrinter(intList);
        }
        private static void ThreeKiller(int[] numbers)
        {
            int[] copeyNumbers = new int[numbers.Length]; 
            numbers.CopyTo(copeyNumbers, 0 );
            for (int i = 0; i < copeyNumbers.Length; i++)
            {
                if (copeyNumbers[i] % 3 == 0)
                {
                    copeyNumbers[i] = 0;
                }
            }
            NumberPrinter(copeyNumbers);
        }

        private static List<int> OddKiller(List<int> numberList)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    evenNumbers.Add(numberList[i]);
                }
            }
            return evenNumbers;
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool inList = false;
            for(int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == searchNumber)
                {
                    inList = true; break;
                }
                
            }
            if (inList)
            {
                Console.WriteLine($"The number {searchNumber} is in the List.");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber} is not in this List.");
            }
        }

        private static void Populater(List<int> numberList, int populateNumber)
        {
            Random rng = new Random();
            for (int i = 0; i < populateNumber; i++)
            {
                numberList.Add((int)((50 - 0 + 1) * rng.NextDouble() + 0));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            //Console.WriteLine($"Random Number: {rng.NextDouble()}");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)((50 - 0 + 1) * rng.NextDouble() + 0);

            }
        }        

        private static void ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            int counter = 0;

            for(int i  = array.Length - 1; i >= 0; i--)
            {
                
                reverseArray[counter] = array[i];
                counter++;
            }
            NumberPrinter(reverseArray);

        }
        private static void SortArray(int[] array)
        {
            Array.Sort(array);

            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
