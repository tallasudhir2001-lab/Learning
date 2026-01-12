using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] array)
        {
            Array.Sort(array);
            /*always sort if it is Three Some
            sort enables the two pointer approach when sum goes less will increase left goes high will decrease right
            */
            IList<IList<int>> result =new List<IList<int>>();
            for(int i = 0; i < array.Length-2; i++)
            {
                /*this is to avoid duplicate triplets because 
                 * for 0 th elemet we have already created all possible triplets
                 * now if the next index's element is the same wil end up creating same triplets again.
                 */
                if(i>0 && array[i] == array[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right=array.Length-1;
                while(left < right)
                {
                    int sum = array[i] + array[left]+array[right];
                    if (sum == 0)
                    {
                        result.Add(new int[] { array[i], array[left], array[right]});

                        /*
                         * Once a triplet sum equals 0, reusing the same value again for left or right can never produce a new valid triplet.
                         * If the complementary value exists → it forms a duplicate triplet
                         * If it does not exist → the sum will never be 0

                         Therefore, skipping that value is always safe.
                         */
                        while (left < right && array[left] == array[left + 1])
                        {
                            left++;
                        }
                        while(left<right && array[right] == array[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
                    }
                    else if(sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
