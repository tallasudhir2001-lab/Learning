using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class SingleNumber
    {
        /*Every element appears twice except for one number print that number
         * XOR properties (very important)

            a ^ a = 0 → same numbers cancel out

            a ^ 0 = a

        Imp -> Each duplicate contributes two identical bits

1 ^ 1 = 0, 0 ^ 0 = 0

Only the single number contributes an unpaired bit

So every bit position independently resolves to the correct answer.
         */
        public int SingleNumberInArray(int[] array)
        {
            /*
             * [4,5,4]
             * 100
             * 101
             * 
             * 001
             * 100
             * 101(5)
             * 
             * Common bits cancels out 
             */
            int singleNumber = 0;
            foreach(int num in array)
            {
                singleNumber ^= num;
            }
            return singleNumber;
        }
        public int SingleNumberOtherApproch(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = 0;
                }
                dict[nums[i]]++;
            }
            foreach (KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }
            return -1;
        }
    }
}
