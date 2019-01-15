//-----------------------------------------------------------------------
// <copyright file="Anagram.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used to find the anagram of a string
    /// </summary>
    public class Anagram
    {
        /// <summary>
        ///  to find anagram.
        /// </summary>
        public void ToFindAnagram()
        {
            Console.WriteLine("enter first string");
            string firstString = Console.ReadLine();
            Console.WriteLine("enter second string");
            string secondString = Console.ReadLine();
            ////converting first string in to character array
            char[] firstStringCharactres = firstString.ToCharArray();
            ////converting second string in to character array
            char[] secondStringCharactres = secondString.ToCharArray();
            ////sorting the first String Charactres 
            Array.Sort(firstStringCharactres);
            ////sorting the second String Charactres
            Array.Sort(secondStringCharactres);
            ////converting back the character array to string
            string firstcharArrayToString = new string(firstStringCharactres);
            ////converting back the character array to string
            string secondcharArrayToString = new string(secondStringCharactres);
            ////if condition is used to find whether two strings anagrams or not
            if (firstcharArrayToString.Equals(secondcharArrayToString))
            {
                Console.WriteLine("given two strings are anagrams");
            }
            else
            {
                Console.WriteLine("given two strings are not anagrams");
            }

            Console.ReadLine();
        }
    }
}