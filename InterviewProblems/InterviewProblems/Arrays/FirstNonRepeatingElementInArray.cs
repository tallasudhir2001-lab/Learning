using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class FirstNonRepeatingElementInArray
    {
        public void FirstNonRepeatingElement(int[] array)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for(int i = 0; i < array.Length; i++)
            {
                if (!dict.ContainsKey(array[i]))
                {
                    dict[array[i]] = 1;
                }
                else
                {
                    dict[array [i]]++;
                }
            }
            foreach(KeyValuePair<int,int> kvp in dict){
                if(kvp.Value == 1)
                {
                    Console.WriteLine($"First Non Repeating Element is {kvp.Key}");
                    break;
                }
            }
        }
    }
}
