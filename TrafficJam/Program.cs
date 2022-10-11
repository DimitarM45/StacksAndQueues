using System;
using System.Collections.Generic;

namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedCars = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int counter = 0;

            bool flag = false;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 1; i <= allowedCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");

                            counter++;
                        }
                    }
                }

                else
                    cars.Enqueue(input);

                if (flag) break;

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
