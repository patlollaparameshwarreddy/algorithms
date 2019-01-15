//-----------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for converting decimal number in to binary number
    /// </summary>
    public class DecimalToBinary
    {
        /// <summary>
        /// Conversions this instance.
        /// </summary>
        public void Conversion()
        {
            Utility utility = new Utility();
            string binaryNumber = utility.ToBinary();
            Console.WriteLine("the binary number of the given number is " + binaryNumber);
        }
    }
}
