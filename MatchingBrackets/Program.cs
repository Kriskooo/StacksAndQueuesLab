using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    brackets.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex = brackets.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }

            }
        }
    }
}
