using System;

namespace _01._USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            double moneyConverted = money * 1.79549;

            Console.WriteLine(moneyConverted);
        }
    }
}
