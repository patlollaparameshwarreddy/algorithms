//-----------------------------------------------------------------------
// <copyright file="Binary.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for swapping the nibbles and finding the new decimal number
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// Creates new number.
        /// </summary>
        public void NewNumber()
        {
            Utility utility = new Utility();
            string binaryNumber = utility.ToBinary();
            ////if condition is used for converting the binary number in to 8 bits
            if (binaryNumber.Length < 8)
            {
                while (binaryNumber.Length < 8)
                {
                    binaryNumber = 0 + binaryNumber;
                }
            }

            string nibble1 = binaryNumber.Substring(0, 4);
            string nibble2 = binaryNumber.Substring(4);
            string newBinaryNumber = nibble2 + nibble1;
            int newDecimalNumber = 0;
            int index = 0;
            ////this for loop is used for converting binary number in to decimal number
            for (int i = newBinaryNumber.Length - 1; i >= 0; i--)
            {
                string numberInCharForm = newBinaryNumber[index] + string.Empty;
                int number = Convert.ToInt32(numberInCharForm);
                index++;
                newDecimalNumber = (int)((number * Math.Pow(2, i)) + newDecimalNumber);
            }

            /// added code in binary
            Console.WriteLine("new decimal number is " + newDecimalNumber);
            Console.ReadLine();
        }
    }
}
