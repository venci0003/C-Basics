using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();

            int SeriesTime = int.Parse(Console.ReadLine());

            int LunchBreakTime = int.Parse(Console.ReadLine());

            double timeforSeries = LunchBreakTime * 5.0 / 8;

            if (timeforSeries >= SeriesTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeforSeries - SeriesTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(SeriesTime - timeforSeries)} more minutes.");
            }
        }
    }
}