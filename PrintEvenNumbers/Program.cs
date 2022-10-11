using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> evenNumbers = new Queue<int>();

            foreach (int integer in integers)
                if (integer % 2 == 0) evenNumbers.Enqueue(integer);

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
