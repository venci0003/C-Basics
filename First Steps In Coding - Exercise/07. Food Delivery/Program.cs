using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());
            //Calculations
            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.40;
            double veganDishPrice = vegan * 8.15;
            double sumOfAllDishes = chickenPrice + fishPrice + veganDishPrice;
            double discount = sumOfAllDishes * 0.2;
            double result = sumOfAllDishes + discount + 2.50;
            Console.WriteLine(result);
        }
    }
}