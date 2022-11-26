using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());

            int lenght = int.Parse(Console.ReadLine());

            int hight = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int freeSpace = width * lenght * hight;

            int spaceTaken = 0;

            while (input != "Done")
            {
                spaceTaken += int.Parse(input);
                if (spaceTaken >= freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {spaceTaken - freeSpace} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{Math.Abs(freeSpace - spaceTaken)} Cubic meters left.");
            }
        }
    }
}