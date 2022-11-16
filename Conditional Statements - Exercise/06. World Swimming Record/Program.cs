using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeNeeded = double.Parse(Console.ReadLine());
            double slowDown = 0;

            if (distanceMeters >= 15)
            {
                slowDown = Math.Floor(distanceMeters / 15) * 12.5;
            }
            double timeSum = distanceMeters * timeNeeded + slowDown;

            if (recordSeconds > timeSum)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {timeSum:f2} seconds.");
            }
            else
            {

                Console.WriteLine($"No, he failed! He was {Math.Abs(timeSum - recordSeconds):f2} seconds slower.");
            }
        }
    }
}