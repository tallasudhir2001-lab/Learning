using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Stack
{
    internal class LC_MakeTheStringGreat
    {
        /*
         * Problem idea (simple words):
        You’re given a string s.
        You must repeatedly remove adjacent characters if:

        they are the same letter

        but have different cases
        (example: aA or Bb)

        Keep doing this until no more such pairs exist.
         */
        public string MakeTheStringGreat(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if(stack.Count>0 && Math.Abs(c - stack.Peek()) == 32)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return new string(stack.Reverse().ToArray());
        }
    }
}
