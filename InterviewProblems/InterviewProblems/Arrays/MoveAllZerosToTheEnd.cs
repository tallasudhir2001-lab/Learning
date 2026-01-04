using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Arrays
{
    internal class MoveAllZerosToTheEnd
    {
        public void MoveAllZerosToTheRightSide(int[] array)
        {
            int index = 0, i=0,arrayLength=array.Length;
            while (i < arrayLength)
            {
                if(array[i] != 0)
                {
                    array[index]=array[i];
                    index++;
                }
                i++;
            }
            while (index < arrayLength)
            {
                array[index] = 0;
                index++;
            }
            Console.WriteLine(string.Join(" ", array));
        }
        public void MoveAllZerosToTheLeftSide(int[] array)
        {
            int index=array.Length-1,i = array.Length - 1;
            while (i >= 0)
            {
                if(array[i] != 0)
                {
                    array[index] = array[i];
                    index--;
                }
                i--;
            }
            while (index >= 0)
            {
                array[index] = 0;
                index--;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
