using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class Anagram
    {
        public bool AreAnagrams(string s, string t)
        {
            int[] arr = new int[26];
            if (s.Length != t.Length)
            {
                return false;
            }
            foreach(char c in s)
            {
                arr[c - 'a']++;
            }
            foreach(char c in t)
            {
                arr[c - 'a']--;
                if (arr[c - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
