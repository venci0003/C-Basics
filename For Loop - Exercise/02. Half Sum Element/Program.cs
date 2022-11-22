using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= loops; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }
            int sumwithoutmax = sum - max;
            if (max == sumwithoutmax)
            {
                Console.WriteLine($"Yes \nSum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumwithoutmax);
                Console.WriteLine($"No \nDiff = {diff}");
            }

        }
    }
}