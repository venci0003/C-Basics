using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= loops; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;

            }
            Console.WriteLine(result);
        }
    }
}
