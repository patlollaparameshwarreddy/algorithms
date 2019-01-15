//-----------------------------------------------------------------------
// <copyright file="MergeSort.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithms
{
    using System;

    /// <summary>
    /// this class is used for doing merge sort
    /// </summary>

    public class MergeSort
    {
        /// <summary>
        /// The array
        /// </summary>
        private string[] array;
        /// <summary>
        /// The temporary merge array
        /// </summary>
        private string[] tempMergeArray;
        int length;

        /// <summary>
        /// This method is declared and defined to 
        /// initialized instance array and variable
        /// </summary>
        public void Sort(String[] inputArr)
        {
            ////initialising instance array and variable
            this.array = inputArr;
            this.length = inputArr.Length;
            this.tempMergeArray = new String[length];
            ////calling method recursively to sort all the data
            DivideArray(0, length - 1);
        }
        /// <summary>
        /// this method will divide the array in parts
        /// </summary>
        /// <param name="lowerIndex"></param>
        /// <param name="higherIndex"></param>
        public void DivideArray(int lowerIndex, int higherIndex)
        {
            if (lowerIndex < higherIndex)
            {
                ////finding middle element by adding lower 
                ///and highest and dividing by 2
                int middle = lowerIndex + (higherIndex - lowerIndex) / 2;
                ////calling method recursively 
                ////first will divide till lower to middle
                DivideArray(lowerIndex, middle);
                ////this recusive method will divide from middle+1 to higherIndex
                DivideArray(middle + 1, higherIndex);
                ////this recursive method will 
                MergeArray(lowerIndex, middle, higherIndex);
            }
        }

        /// <summary>
        /// this method will take parameters 
        /// </summary>
        /// <param name="lowerIndex"></param>
        /// <param name="middle"></param>
        /// <param name="higherIndex"></param>
        public void MergeArray(int lowerIndex, int middle, int higherIndex)
        {
            for (int m = lowerIndex; m <= higherIndex; m++)
            {
                this.tempMergeArray[m] = array[m];
            }

            int i = lowerIndex;
            int j = middle + 1;
            int k = lowerIndex;
            while (i <= middle && j <= higherIndex)
            {
                if (string.Compare(tempMergeArray[i], tempMergeArray[j]) <= 0)
                {
                    this.array[k] = tempMergeArray[i];
                    i++;
                }
                else
                {
                    this.array[k] = tempMergeArray[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                this.array[k] = this.tempMergeArray[i];
                k++;
                i++;
            }
        }
    }
}
