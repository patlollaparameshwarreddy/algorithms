//-----------------------------------------------------------------------
// <copyright file="MonthlyPayments.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    /// <summary>
    /// this class is used for finding the monthly payments based on principle,
    /// rate of interest and number of years
    /// </summary>
    public class MonthlyPayments
    {
        /// <summary>
        /// Calculations the of monthly payments.
        /// </summary>
        public void CalculationOfMonthlyPayments()
        {
            Utility utility = new Utility();
            utility.MonthlyPayment();
        }
    }
}
