using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class OrderWords
    {
        public void ReOrderWords()
        {
            string [] words = "m1y nam2e 3is 4talla sudhir5".Split(' ');
            (string val, int idx)[] arr = new (string val, int idx)[words.Length];
            for(int i=0;i<words.Length;i++)
            {
                string word = words[i];
                int index = -1;
                string w = "";
                foreach(char c in word)
                {
                    if (char.IsDigit(c))
                    {
                        index = c - '0';
                    }
                    else
                    {
                        w+= c;
                    }
                }
                arr[i]=(w, index);
            }
             Array.Sort(arr, (a, b) => a.idx.CompareTo(b.idx));
             string resultString = "";
            foreach((string val,int idx) in arr)
            {
                resultString += val+" ";
            }
            Console.WriteLine(resultString);

        }
    }
}
