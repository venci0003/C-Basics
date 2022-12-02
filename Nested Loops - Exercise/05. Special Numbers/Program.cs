using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());


            for (int z = 1; z <= 9; z++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int x = 1; x <= 9; x++)
                    {
                        for (int y = 1; y <= 9; y++)
                        {
                            if (loops % z == 0 && loops % k == 0 && loops % x == 0 && loops % y == 0)
                            {
                                Console.Write($"{z}{k}{x}{y} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

