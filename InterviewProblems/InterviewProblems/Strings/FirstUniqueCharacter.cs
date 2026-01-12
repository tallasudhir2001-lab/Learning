using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings
{
    internal class FirstUniqueCharacter
    {
        public int FirstUniqueCharacterIndexInString(string s) {
            int[] freq = new int[26];
            foreach(char c in s)
            {
                freq[c - 'a']++;
            }
            for(int i=0; i<s.Length; i++)
            {
                if (freq[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
        //If they had not asked for index we can use hashmap too.
    }
}
