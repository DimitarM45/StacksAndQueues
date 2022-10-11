using System;
using System.Collections.Generic;

namespace ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversedString = new Stack<char>();

            foreach (char letter in input)
                reversedString.Push(letter);

            Console.Write(string.Join(null, reversedString));
        }
    }
}
