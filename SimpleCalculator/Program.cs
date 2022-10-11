using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            input = input.Reverse().ToArray();

            Stack<string> symbols = new Stack<string>();

            foreach (string symbol in input)
                symbols.Push(symbol);

            int result = int.Parse(symbols.Pop());

            while (symbols.Count > 0)
            {
                string oper = symbols.Pop();
                int secondNumber = int.Parse(symbols.Pop());

                if (oper == "+")
                    result += secondNumber;

                else
                    result -= secondNumber;
            }

            Console.WriteLine(result);
        }
    }
}
