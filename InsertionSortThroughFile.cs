//-----------------------------------------------------------------------
// <copyright file="InsertionSortThroughFile.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for sorting strings by using insertion sort
    /// </summary>
    public class InsertionSortThroughFile
    {
        /// <summary>
        /// this method is used for taking the input from the file and sort it
        /// </summary>
        public void SortingStringsInFile()
        {
            Utility utility = new Utility();
            ////the variable text is used to store the location of your file
            string text = null;
            ////we make use of try and catch block because there is io exception and directory not found exception
            try
            {
                text = System.IO.File.ReadAllText(@"C:\Users\Admin\Desktop\insertionSort.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] words = text.Split(new char[] { ' ' });
            utility.LogicOfInsertionSortOfString(words);
        }
    }
}
