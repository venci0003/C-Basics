using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());

            int deposit = int.Parse(Console.ReadLine());

            double yearlyPercentage = double.Parse(Console.ReadLine());

            double increase = depositedSum * yearlyPercentage / 100.0;

            double increaseInAMonth = increase / 12;

            double sum = depositedSum + deposit * increaseInAMonth;

            Console.WriteLine($"{sum:f2}");
        }
    }
}