using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            string[] input = Console.ReadLine().Split();

            string command = input[0].ToLower();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        int firstNumber = int.Parse(input[1]);
                        int secondNumber = int.Parse(input[2]);

                        numbers.Push(firstNumber);
                        numbers.Push(secondNumber);
                        break;

                    case "remove":
                        int count = int.Parse(input[1]);

                        if (count <= numbers.Count)
                        {
                            for (int i = 1; i <= count; i++)
                                numbers.Pop();
                        }

                        break;

                    default:
                        break;
                }

                input = Console.ReadLine().Split();

                command = input[0].ToLower();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
