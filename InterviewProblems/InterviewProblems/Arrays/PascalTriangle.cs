using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class PascalTriangle
    {
        /* don't go for graph coordinates but array co ordinates
         *              1(0,0)
         *          1(1,0)  1(1,1) if j=0 or i=j it is 1
         * 1(2,0)      2(matrix[row-1][col-1]+matrix[row-1][col] not col+1 (2-1,1-1) + (2-1,1)
         */
        public IList<IList<int>> printPasacalTriangle(int num)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            for(int i = 0; i < num; i++)
            {
                IList<int> row =new List<int>();
                for(int j=0;j<=i;j++)
                {
                    if(j==0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(triangle[i - 1][j - 1] + triangle[i-1][j]);
                    }
                }
                triangle.Add(row);
            }
            return triangle;
        }
    }
}
