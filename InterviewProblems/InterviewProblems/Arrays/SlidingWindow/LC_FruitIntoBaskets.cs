using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class LC_FruitIntoBaskets
    {
        public int FruitsIntoBasket(int[] trees)
        {
           Dictionary<int,int> dic = new Dictionary<int,int>();
            int left = 0, maxFruits = 0;
            for (int right = 0; right < trees.Length - 1; right++)
            {
                if (!dic.ContainsKey(trees[right]))
                {
                    dic[trees[right]] = 0;
                }
                dic[trees[right]]++;
                while (dic.Count > 2)
                {
                    dic[trees[left]]--;
                    if (dic[trees[left]] == 0)
                    {
                        dic.Remove(trees[left]);
                    }
                    left++;
                }
                maxFruits = Math.Max(maxFruits, right - left + 1);
            }
            return maxFruits;
        }
    }
}
