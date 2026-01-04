using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class RomanToInteger
    {
        public int ConvertRomanToInteger(string s)
        {
            int total = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            for(int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && dict[s[i]] < dict[s[i + 1]])
                {
                    total-= dict[s[i]];
                }
                else
                {
                    total+= dict[s[i]];
                }
            }
            return total;
        }
    }
}
