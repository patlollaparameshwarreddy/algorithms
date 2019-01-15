//-----------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used to find the prime numbers
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// Finds the prime numbers.
        /// </summary>
        public void FindPrimeNumbers()
        {
            Utility utility = new Utility();
           ArrayList primeNumbers = utility.ListOfPrimeNumbers();
            Console.WriteLine("list of prime numbers");
            ////for loop is used for retriving the prime numbers from arraylist
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.WriteLine(primeNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
