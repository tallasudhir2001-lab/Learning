using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Stack
{
    internal class Stack
    {
        public void StackFunctions()
        {
            Stack<int> stack = new Stack<int>();
            //adding element
            stack.Push(1);
            //removing element
            stack.Pop();
            //Read the top element
            Console.WriteLine(stack.Peek());
        }
    }
}
