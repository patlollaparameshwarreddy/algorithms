//-----------------------------------------------------------------------
// <copyright file="BinarySearchThroughFile.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used to search a string from file using binary search
    /// </summary>
    public class BinarySearchThroughFile
    {
        /// <summary>
        /// Binary search of a string in file.
        /// </summary>
        public void BinarySearchOfAStringInFile()
        {
            Utility utility = new Utility();
            ////the variable text is used to store the location of your file
            string text = null;
            ////we make use of try and catch block because there is io exception and directory not found exception
            try
            {
                text = System.IO.File.ReadAllText(@"C:\Users\Admin\Desktop\BinarySearchOfWord.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 

            string[] words = text.Split(new char[] { ' ' });
            Array.Sort(words);
            utility.LogicOfBinarySearchOfString(words);
        }
    }
}
