using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());

            int length = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int cake = width * length;

            int piecesOfCakeTaken = 0;

            while (input != "STOP")
            {
                piecesOfCakeTaken = int.Parse(input);

                cake -= piecesOfCakeTaken;
                if (cake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
        }
    }
}