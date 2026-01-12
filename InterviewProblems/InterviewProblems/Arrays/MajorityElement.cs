using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class MajorityElement//(more than n/2 times)
    {
        //works only if the elemet is repeated more than len(array)/2 times ,if not use a different algorithm
        public int MajorityElementUsingHashMap(int[] array)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            foreach (int element in array)
            {
                if (!dict.ContainsKey(element))
                {
                    dict[element] = 0;
                }
                dict[element]++;
                if(dict[element] > array.Length / 2)
                {
                    return element;
                }
            }
            return -1;
        }
        //works only if the elemet is repeated more than len(array)/2 times ,if not use a different algorithm
        public int majorityElementUsingSorting(int[] array)
        {
            Array.Sort(array);
            return array[array.Length/2];
        }

        //works only if the elemet is repeated more than len(array)/2 times ,if not use a different algorithm
        public int MajorityElementBestApproch(int[] array)
        {
            int candidate = 0;
            int votes = 0;
            foreach(int num in array)
            {
                if (votes == 0)
                {
                    candidate = num;
                }
                if (candidate == num)
                {
                    votes++;
                }
                else
                {
                    votes--;
                }
            }
            return candidate;
        }
    }
}
