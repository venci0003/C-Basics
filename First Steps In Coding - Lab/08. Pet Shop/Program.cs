using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodAmount = int.Parse(Console.ReadLine());

            int catFoodAmount = int.Parse(Console.ReadLine());

            double catFoodPrice = catFoodAmount * 4;

            double dogFoodPrice = dogFoodAmount * 2.50;

            double result = dogFoodPrice + catFoodPrice;

            Console.WriteLine($"{result} lv.");
        }
    }
}