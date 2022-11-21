using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int i = 1; i <= loops; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            if (odd == even)
            {
                Console.WriteLine($"Yes \nSum = {odd}");
            }
            else
            {
                Console.WriteLine($"No \nDiff = {Math.Abs(even - odd)} ");
            }

        }
    }
}
