using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int p1 = 0;

            int p2 = 0;

            int p3 = 0;

            int p4 = 0;

            int p5 = 0;

            for (int i = 1; i <= loops; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }
            }

            double p1Percentage = p1 * 100d / loops;

            double p2Percentage = p2 * 100d / loops;

            double p3Percentage = p3 * 100d / loops;

            double p4Percentage = p4 * 100d / loops;

            double p5Percentage = p5 * 100d / loops;

            Console.WriteLine($"{p1Percentage:f2}%");

            Console.WriteLine($"{p2Percentage:f2}%");

            Console.WriteLine($"{p3Percentage:f2}%");

            Console.WriteLine($"{p4Percentage:f2}%");

            Console.WriteLine($"{p5Percentage:f2}%");
        }
    }
}