using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            for (int i = 1; i <= loops; i++)
            {
                left += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= loops; i++)
            {
                right += int.Parse(Console.ReadLine());
            }
            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }
        }
    }
}
