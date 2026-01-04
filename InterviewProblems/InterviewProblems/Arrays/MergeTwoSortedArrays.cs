using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class MergeTwoSortedArrays
    {
        public void MergeSortedArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length+array2.Length];
            int i = 0, j = 0,k=0;
            while (i < array1.Length &&j < array2.Length)
            {
                if(array1[i] < array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else if(array1[i] > array2[j])
                {
                    mergedArray[k++] = array2[j++];
                }
                else
                {
                    mergedArray[k++] = array1[i++];
                    mergedArray[k++] = array2[j++];
                }
            }
            while (i < array1.Length)
            {
                mergedArray[k++]=array1[i++];
            }
            while(j < array2.Length)
            {
                mergedArray[k++] = array2[j++];
            }
            Console.WriteLine(string.Join(" ", mergedArray));
        }
    }
}
