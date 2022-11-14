using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());

            int markers = int.Parse(Console.ReadLine());

            int cleaningDetergent = int.Parse(Console.ReadLine());

            int discount = int.Parse(Console.ReadLine());

            double pensPrice = pens * 5.80;

            double markersPrice = markers * 7.20;

            double cleaningDetergentPrice = cleaningDetergent * 1.20;

            double finalSum = (pensPrice + markersPrice + cleaningDetergentPrice);

            double discountResult = finalSum - (finalSum * discount / 100.0);

            Console.WriteLine(discountResult);
        }
    }
}