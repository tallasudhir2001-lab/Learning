using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class TwoSum
    {
        public (int index1, int index2) TwoSumBadApproch(int[] array, int target)
        {
            //[2,7,11,15]
            for (int i = 0; i < array.Length; i++)//4
            {
                for (int j = 1; j < array.Length; j++)//4
                {
                    if(array[i] + array[j] == target)
                    {
                        return (i,j);
                        break;
                    }
                }
            }
            return (-1,-1);
        }

        //using hashMap(Dictionary in c#)
        public (int index1, int index2) TwoSumProblem(int[] array, int target)
        {
            Dictionary<int,int> dict=new Dictionary<int,int>();
            for(int i = 0;i < array.Length;i++)
            {
                int compliment = target - array[i];
                if (dict.ContainsKey(compliment))
                {
                    return (dict[compliment],i);
                }
                if (!dict.ContainsKey(array[i]))
                {
                    dict.Add(array[i], i);
                }
            }
            return (-1, -1);
        }
    }
}
