//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for finding the change to be given for the given amount
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Counting the change.
        /// </summary>
        public void CountingChange()
        {
            try
            {
                Utility utility = new Utility();
                int count = 0;
                int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
                Console.WriteLine("enter ammount");
                int ammount = utility.GetInt();
                ////for loop is used for finding the number of notes to be given as change
                for (int i = 0; i < notes.Length; i++)
                {
                    while ((ammount / notes[i] > 0) && ammount >= 1)
                    {
                        int change = ammount / notes[i];
                        Console.WriteLine("number of " + notes[i] + " is " + change);
                        count = count + change;
                        ammount = ammount % notes[i];
                    }
                }

                Console.WriteLine("minimum number of notes required to give change is " + count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}