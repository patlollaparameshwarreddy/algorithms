//-----------------------------------------------------------------------
// <copyright file="SqrtOfNonNegativeNumber.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for finding roots of non negative number
    /// </summary>
    public class SqrtOfNonNegativeNumber
    {
        /// <summary>
        /// SQRTs this instance.
        /// </summary>
        public void Sqrt()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("enter number");
                double c = utility.GetDouble();
                double epsilon = 1e-15;
                double t = c;
                while (Math.Abs(t - (c / t)) > (epsilon * t))
                {
                    t = ((c / t) + t) / 2.0;
                }

                Console.WriteLine(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
