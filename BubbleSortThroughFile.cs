//-----------------------------------------------------------------------
// <copyright file="BubbleSortThroughFile.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for sorting of integers using bubble sort
    /// </summary>
    public class BubbleSortThroughFile
    {
        /// <summary>
        /// this method is used for taking the data from file and sorting it.
        /// </summary>
        public void SortingIntigersInFile()
        {
            Utility utility = new Utility();
            ////the variable text is used to store the location of your file
            string text = null;
            ////we make use of try and catch block because there is io exception and directory not found exception
            try
            {
                text = System.IO.File.ReadAllText(@"C: \Users\Admin\Desktop\BubbleSort.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] numbersInArray = text.Split(new char[] { ' ' });
            int[] numbers = Array.ConvertAll(numbersInArray, int.Parse);
            utility.LogicForBubbleSortOfIntegers(numbers);
        }
    }
}
