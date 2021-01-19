using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> elements = new Stack<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                elements.Push(numbers[i]);
            }
            List<string> command = Console.ReadLine().Split().ToList();
            command[0] = command[0].ToLower();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    elements.Push(int.Parse(command[1]));
                    elements.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    if (int.Parse(command[1]) > elements.Count)
                    {
                        command = Console.ReadLine().Split().ToList();
                        command[0] = command[0].ToLower();
                        continue;
                    }
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        elements.Pop();
                    }
                }
                command = Console.ReadLine().Split().ToList();
                command[0] = command[0].ToLower();
            }
            Console.WriteLine($"Sum: {elements.Sum()}");
           
        }
    }
}
