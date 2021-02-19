using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LectionAlgo
{
    public class MergeSort
    {
        private int[] array;
        private int[] sortedArr;

        public MergeSort(int[] arr)
        {
            array = arr;
        }
        public int[] SortedArray => Segregation(this.array);
        private int[] MergeArray(int[] left, int[] right)
        {
            sortedArr = new int[left.Length + right.Length];
            int leftIndex = 0, rightIndex = 0, sortedIndex = 0;

            //Merging arrays
            while (leftIndex < left.Length || right.Length > rightIndex)
            {
                if (leftIndex < left.Length && right.Length > rightIndex)
                {
                    if (left[leftIndex] > right[rightIndex])
                    {
                        sortedArr[sortedIndex] = right[rightIndex];
                        rightIndex++;
                        sortedIndex++;
                    }
                    else
                    {
                        sortedArr[sortedIndex] = left[leftIndex];
                        leftIndex++;
                        sortedIndex++;
                    }
                }

                // check wheather there is item left
                else if (leftIndex < left.Length)
                {
                    sortedArr[sortedIndex] = left[leftIndex];
                    leftIndex++;
                    sortedIndex++;
                }
                else if (rightIndex < right.Length)
                {
                    sortedArr[sortedIndex] = right[rightIndex];
                    rightIndex++;
                    sortedIndex++;
                }
            }
            return sortedArr;
        }
        private int[] Segregation(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int midPoint = array.Length / 2;

            int[] left = new int[midPoint];
            int[] right;

            if (array.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else right = new int[midPoint + 1];

            //leftPart
            for (int index = 0; index < midPoint; index++)
            {
                left[index] = array[index];
            }

            //rightPart
            for (int index = midPoint, counter = 0; index < array.Length; counter++, index++)
            {
                right[counter] = array[index];
            }

            //Continue with Segregation
            left = Segregation(left);
            right = Segregation(right);
            sortedArr = MergeArray(left, right);
            return sortedArr;
        }
    }
}