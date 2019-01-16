//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;
    using System.Collections;
    using System.Diagnostics;

    /// <summary>
    /// this class is used for writing the common logics that are required by other class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets the integer.
        /// </summary>
        /// <returns> it returns the integer that is required</returns>
        private Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// returns the integer
        /// </summary>
        /// <returns> by using this we get integer value</returns>
        public int GetInt()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <returns>it returns the double value that is required</returns>
        public double GetDouble()
        {
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }

        /// <summary>
        /// Lists the of prime numbers.
        /// </summary>
        /// <returns>it returns the array list that consists of prime numbers</returns>
        public ArrayList ListOfPrimeNumbers()
        {
            Console.WriteLine("enter range ");
            int range = this.GetInt();
            ArrayList storePrimeNumbers = new ArrayList();
            ////this loop is used for taking the numbes from 1 to given range
            for (int i = 1; i <= range; i++)
            {
                int count = 0;
                ////this loop is used for dividing the i by the j up to given range
                for (int j = 1; j <= range; j++)
                {
                    if ((i % j) == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    storePrimeNumbers.Add(i);
                }
            }

            return storePrimeNumbers;
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        public void DayOfWeek()
        {
            string[] week = { "Sunday", "monday", "tuesday", "wednesday", "thrusday", "friday", "saturday" };
            Console.WriteLine("enter year in the yyyy formate");
            int y = this.GetInt();
            Console.WriteLine("enter month");
            int m = this.GetInt();
            Console.WriteLine("enter day");
            int d = this.GetInt();
            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = (m + 12) * (((14 - m) / 12) - 2);
            int d0 = (d + x + (31 * m0 / 12)) % 7;
            Console.WriteLine("the day of the week is " + week[d0]);
        }

        /// <summary>
        /// Temperature the conversion.
        /// </summary>
        public void TemperaturConversion()
        {
            Console.WriteLine("enter 1 to convert Celsius to Fahrenheit or enter 2 to convert Fahrenheit to Celsius ");
            int storeCaseValue = this.GetInt();
            switch (storeCaseValue)
            {
                case 1:
                    Console.WriteLine("enter temperature in Celsius");
                    double celsius = this.GetInt();
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("temperature in fahrenheit is " + fahrenheit);
                    break;
                case 2:
                    Console.WriteLine("enter temperature in Fahrenheit ");
                    int fahrenheit1 = this.GetInt();
                    int celsius1 = (fahrenheit1 - 32) * 5 / 9;
                    Console.WriteLine("temperature in Celsius  is " + celsius1);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Monthlies the payment.
        /// </summary>
        public void MonthlyPayment()
        {
            Console.WriteLine("enter principle ");
            int principle = this.GetInt();
            Console.WriteLine("enter number of years");
            double years = this.GetDouble();
            Console.WriteLine("enter rate of intrest");
            double rate = this.GetDouble();
            double n = 12 * years;
            double r = rate / (12 * 100);
            double payment = (principle * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("the monthly payment is " + payment);
            Console.ReadLine();
        }

        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <returns>returns the string that consists of binary number</returns>
        public string ToBinary()
        {
            Console.WriteLine("enter decimal number");
            ////this variable is used to store the decimal number given by the user
            int decimalNumber = this.GetInt();
            int temp = decimalNumber;
            string binaryNumber = string.Empty;
            while (decimalNumber >= 1)
            {
                int rem = decimalNumber % 2;
                binaryNumber = rem + binaryNumber;
                decimalNumber = decimalNumber / 2;
            }

            if (binaryNumber.Length >= 4)
            {
                ////Console.WriteLine("the binary number of " + temp + " is " + binaryNumber);
                return binaryNumber;
            }
            else
            {
                while (binaryNumber.Length < 4)
                {
                    binaryNumber = 0 + binaryNumber;
                }
            }

            return binaryNumber;
        }

        /// <summary>
        /// Sizes the of array.
        /// </summary>
        /// <returns>this method will return number of elements to be entered  </returns>
        public int SizeOfArray()
        {
            Utility utility = new Utility();
            Console.WriteLine("enter number of elements to enter in to array");
            int size = utility.GetInt();
            return size;
        }

        /// <summary>
        /// this method is used for sorting of integers using bubble sort
        /// </summary>
        public void BubbleSortOfIntegers()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            int[] numbers = new int[size];
            Console.WriteLine("enter integer array elements");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = utility.GetInt();
            }

            this.LogicForBubbleSortOfIntegers(numbers);
        }

        /// <summary>
        /// Insertions sort of integers.
        /// </summary>
        public void InsertionSortOfIteger()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            int[] numbers = new int[size];
            Console.WriteLine("enter integer array elements");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = utility.GetInt();
            }

            this.LogicForInsertionSortOfInteger(numbers);
        }

        /// <summary>
        /// binary  search of integer.
        /// </summary>
        public void BinarySearchOfInteger()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            int[] numbers = new int[size];
            Console.WriteLine("enter integers in ascending order array elements");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = utility.GetInt();
            }

            this.LogicForBinarySearchOfInteger(numbers);
        }

        /// <summary>
        /// Insertions  sort of string.
        /// </summary>
        public void InsertionSortOfString()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            string[] words = new string[size];
            Console.WriteLine("enter string array elements");
            for (int i = 0; i < size; i++)
            {
                words[i] = Console.ReadLine();
            }

            this.LogicOfInsertionSortOfString(words);
        }

        /// <summary>
        /// Bubble sort of string.
        /// </summary>
        public void BubbleSortOfString()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            string[] words = new string[size];
            Console.WriteLine("enter string array elements");
            for (int i = 0; i < size; i++)
            {
                words[i] = Console.ReadLine();
            }

            this.LogicOfBubbleSortOfString(words);
        }

        /// <summary>
        /// Logic for bubble sort of integers.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        public void LogicForBubbleSortOfIntegers(int[] numbers)
        {
            this.stopwatch.Start();
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                for (int j = 0; j <= numbers.Length - 2; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            this.stopwatch.Stop();
            Console.WriteLine("time taken for bubble sort of integer is " + this.stopwatch.Elapsed);
            Console.WriteLine("sorted list");
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Logic for the bubble sort of string.
        /// </summary>
        /// <param name="words">The words.</param>
        public void LogicOfBubbleSortOfString(string[] words)
        {
            this.stopwatch.Start();
            for (int i = 0; i <= words.Length - 1; i++)
            {
                for (int j = 0; j <= words.Length - 2; j++)
                {
                    if (words[j].CompareTo(words[j + 1]) > 0)
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            this.stopwatch.Start();
            Console.WriteLine("time taken for bubble sort of string is " + this.stopwatch.Elapsed);
            Console.WriteLine("sorted list");
            for (int i = 0; i <= words.Length - 1; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Logic for insertion sort of integer.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        public void LogicForInsertionSortOfInteger(int[] numbers)
        {
            this.stopwatch.Start();
            ////this loop is used to iterate till total length -1
            for (int j = 1; j <= numbers.Length - 1; j++)
            {
                int value = numbers[j];
                int index = j;
                ////this loop is used to check whether the previous number is greater than next or not
                while (index > 0 && numbers[index - 1] > value)
                {
                    numbers[index] = numbers[index - 1];
                    index--;
                }

                numbers[index] = value;
            }

            this.stopwatch.Stop();
            Console.WriteLine("time taken for insertion sort of integer is " + this.stopwatch.Elapsed);
            Console.WriteLine("sorted list");
            ////this loop is used to print the sorted list of an array
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Logic for insertion sort of string.
        /// </summary>
        /// <param name="words">The words.</param>
        public void LogicOfInsertionSortOfString(string[] words)
        {
            this.stopwatch.Start();
            ////this loop is used to iterate till total length -1
            for (int j = 1; j <= words.Length - 1; j++)
            {
                string value = words[j];
                int index = j;
                ////this loop is used to check whether the previous number is greater than next or not
                while (index > 0 && words[index - 1].CompareTo(value) > 0)
                {
                    words[index] = words[index - 1];
                    index--;
                }

                words[index] = value;
            }

            this.stopwatch.Start();
            Console.WriteLine("time taken for insertion sort of string is " + this.stopwatch.Elapsed);

            Console.WriteLine("sorted list");
            ////this loop is used to print the sorted list of an array
            for (int i = 0; i <= words.Length - 1; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Logic for binary search of integer.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        public void LogicForBinarySearchOfInteger(int[] numbers)
        {
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;
            Console.WriteLine("enter search element");
            ////this variable is used to store the search element
            int searchElement = this.GetInt();
            this.stopwatch.Start();
            while (firstIndex <= lastIndex)
            {
                int middleIndex = (firstIndex + lastIndex) / 2;
                ////this condition is used checking whether the search element is equal to the middle element 
                if (numbers[middleIndex] == searchElement)
                {
                    Console.WriteLine("the search found at position " + (middleIndex + 1));
                    break;
                }

                ////this condition is used to check whether the search element is greater or less than the middle element
                if (searchElement > numbers[middleIndex])
                {
                    firstIndex = middleIndex + 1;
                }
                else
                {
                    lastIndex = middleIndex - 1;
                }

                if (firstIndex > lastIndex)
                {
                    Console.WriteLine("element not found");
                }
            }

            this.stopwatch.Stop();
            Console.WriteLine("time taken for binary search of integer is " + this.stopwatch.Elapsed);
        }

        /// <summary>
        /// Binary search of string.
        /// </summary>
        public void BinarySearchOfString()
        {
            Console.WriteLine("enter size of an array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter string");
            string[] wordsInArray = new string[size];
            for (int index = 0; index < size; index++)
            {
                wordsInArray[index] = Console.ReadLine();
            }

            Array.Sort(wordsInArray);
            this.LogicOfBinarySearchOfString(wordsInArray);
        }

        /// <summary>
        /// Logic for the binary search of string.
        /// </summary>
        /// <param name="wordsInArray">The words in array.</param>
        public void LogicOfBinarySearchOfString(string[] wordsInArray)
        {
            Console.WriteLine("ente search element");
            ////this variable is used to store the search element
            string searchElement = Console.ReadLine();
            int firstIndex = 0;
            int lastIndex = wordsInArray.Length - 1;
            this.stopwatch.Start();
            ////this loop is used for checking each and every element ina an array
            while (firstIndex <= lastIndex)
            {
                int middleIndex = (firstIndex + lastIndex) / 2;
                ////this condition is used checking whether the search element is equal to the middle element 
                if (wordsInArray[middleIndex].Equals(searchElement))
                {
                    Console.WriteLine("the search element found at position " + (middleIndex + 1));
                    break;
                }

                ////this condition is used to check whether the search element is greater or less than the middle element
                if (searchElement.CompareTo(wordsInArray[middleIndex]) > 0)
                {
                    firstIndex = middleIndex + 1;
                }
                else
                {
                    lastIndex = middleIndex - 1;
                }

                if (firstIndex > lastIndex)
                {
                    Console.WriteLine("element not found");
                }
            }

            this.stopwatch.Stop();
            Console.WriteLine("time taken for binary search of string is " + this.stopwatch.Elapsed);
        }
    }
}