using System;
using System.Collections.Generic;

namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());

            int tossNumber = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 1; i <= tossNumber - 1; i++)
                {
                    string currentPlayer = players.Dequeue();

                    players.Enqueue(currentPlayer);
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
