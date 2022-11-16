using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int videoCards = int.Parse(Console.ReadLine());

            int processors = int.Parse(Console.ReadLine());

            int ram = int.Parse(Console.ReadLine());

            double videoCardPrice = videoCards * 250;

            double processorPrice = processors * (videoCardPrice * 0.35);

            double ramPrice = ram * (videoCardPrice * 0.10);

            double setup = videoCardPrice + processorPrice + ramPrice;

            if (videoCards > processors)
            {
                setup = setup - (setup * 0.15);
            }
            double moneyleft = budget - setup;
            if (moneyleft >= 0)
            {
                Console.WriteLine($"You have {moneyleft:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyleft):f2} leva more!");
            }
        }
    }
}