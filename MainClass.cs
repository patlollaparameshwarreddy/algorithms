//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used to execute all algorithm programs
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            ////testing
            string condition = "null";
            ////this loop is used for running the code countineously util the condition is false
            do
            {
                Console.WriteLine("enter 1 for anagram");
                Console.WriteLine("enter 2 for primenumbers");
                Console.WriteLine("enter 3 for day Of Week");
                Console.WriteLine("enter 4 for temperature conversion");
                Console.WriteLine("enter 5 for anagram and palindrome of prime numbers");
                Console.WriteLine("enter 6 for Vending Machine");
                Console.WriteLine("enter 7 for monthly payments");
                Console.WriteLine("enter 8 for converting decimal to binary");
                Console.WriteLine("enter 9 for Swap nibbles and find the new number");
                Console.WriteLine("enter 10 for Search And Sort");
                Console.WriteLine("enter 11 for the square root of a nonnegative number");
                Console.WriteLine("enter 12 for searching the string in a file");
                Console.WriteLine("enter 13 for insertion sort through file");
                Console.WriteLine("enter 14 for bubble sort of integers through file");
                Console.WriteLine("enter 15 for find your number");
                Console.WriteLine("enter 16 for mergesort");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Anagram anagram = new Anagram();
                        anagram.ToFindAnagram();
                        break;
                    case 2:
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        primeNumbers.FindPrimeNumbers();
                        break;
                    case 3:
                        WeekOfADay weekOfADay = new WeekOfADay();
                        weekOfADay.FindingWeekOfADay();
                        break;
                    case 4:
                        ConversionOfTemperature conversionOfTemperature = new ConversionOfTemperature();
                        conversionOfTemperature.ConvertingTemperatures();
                        break;
                    case 5:
                        PalindromeAndAnagramOfPrimeNumbers palindromeAndAnagramOfPrime = new PalindromeAndAnagramOfPrimeNumbers();
                        palindromeAndAnagramOfPrime.PalindromeOfPrimeNumbers();
                        palindromeAndAnagramOfPrime.AnagramOfPrimeNumbers();
                        break;
                    case 6:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.CountingChange();
                        break;
                    case 7:
                        MonthlyPayments monthlyPayments = new MonthlyPayments();
                        monthlyPayments.CalculationOfMonthlyPayments();
                        break;
                    case 8:
                        DecimalToBinary decimalToBinary = new DecimalToBinary();
                        decimalToBinary.Conversion();
                        break;
                    case 9:
                        Binary binary = new Binary();
                        binary.NewNumber();
                        break;
                    case 10:
                        SearchAndSort searchAndSort = new SearchAndSort();
                        searchAndSort.SearchAndSortedList();
                        break;
                    case 11:
                        SqrtOfNonNegativeNumber sqrtOfNonNegative = new SqrtOfNonNegativeNumber();
                        sqrtOfNonNegative.Sqrt();
                        break;
                    case 12:
                        BinarySearchThroughFile searchThroughFile = new BinarySearchThroughFile();
                        searchThroughFile.BinarySearchOfAStringInFile();
                        break;
                    case 13:
                        InsertionSortThroughFile insertionSortThroughFile = new InsertionSortThroughFile();
                        insertionSortThroughFile.SortingStringsInFile();
                        break;
                    case 14:
                        BubbleSortThroughFile bubbleSortThroughFile = new BubbleSortThroughFile();
                        bubbleSortThroughFile.SortingIntigersInFile();
                        break;
                    case 15:
                        FindYourNumber findYourNumber = new FindYourNumber();
                        findYourNumber.GuessNumber();
                        break;
                    case 16:
                        MergeSort mergeSort = new MergeSort();
                        Console.WriteLine("enter size of array");
                        int size = Convert.ToInt32(Console.ReadLine());
                        string[] words = new string[size];
                        Console.WriteLine("enter strings in to array");
                        for (int k = 0; k < size; k++)
                        {
                            words[k] = Console.ReadLine();
                        }

                        mergeSort.Sort(words);
                        Console.WriteLine("sorted array");
                        foreach (string sortedArray in words)
                        { 
                            Console.WriteLine(sortedArray);
                        }

                        break;
                }

                Console.WriteLine("enter yes to execute remaining programs or enter no to stop execution");
                condition = Console.ReadLine();
            }
            while (condition == "yes");
        }
    }
}
