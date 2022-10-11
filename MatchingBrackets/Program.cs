using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> bracketIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int openingIndex = 0;

                if (input[i] == '(')
                {
                    bracketIndexes.Push(i);

                    continue;
                }

                if (input[i] == ')')
                {
                    openingIndex = bracketIndexes.Pop();

                    Console.WriteLine(input.Substring(openingIndex, i - openingIndex + 1));
                }
            }
        }
    }
}
