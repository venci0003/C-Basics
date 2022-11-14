using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double shoesPrice = tax - tax * (40 / 100.0);
            double trainingKit = shoesPrice - shoesPrice * (20 / 100.0);
            double ball = trainingKit / 4;
            double basketballaccesories = ball / 5;
            double result = tax + shoesPrice + trainingKit + basketballaccesories + ball;
            Console.WriteLine(result);
        }
    }
}
