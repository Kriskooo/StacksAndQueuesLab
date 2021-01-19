using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(' ');
            Stack<string> numbers = new Stack<string>(values.Reverse());

            while (numbers.Count > 1)
            {
                int first = int.Parse(numbers.Pop());
                string equal = numbers.Pop();
                int second = int.Parse(numbers.Pop());
                switch (equal)
                {

                    case "+":

                        numbers.Push((first + second).ToString());

                        break;

                    case "-":

                        numbers.Push((first - second).ToString());

                        break;
                }
            }
                Console.WriteLine(numbers.Pop());
        }
    }
}
