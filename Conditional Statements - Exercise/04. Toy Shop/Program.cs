using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double travel = double.Parse(Console.ReadLine());

            int puzzle = int.Parse(Console.ReadLine());

            int dolls = int.Parse(Console.ReadLine());

            int teddys = int.Parse(Console.ReadLine());

            int minions = int.Parse(Console.ReadLine());

            int toytrucks = int.Parse(Console.ReadLine());

            double toysprice = (puzzle * 2.60) + (dolls * 3) + (teddys * 4.10) + (minions * 8.20) + (toytrucks * 2);
            double amountOfToys = puzzle + dolls + teddys + minions + toytrucks;
            if (amountOfToys >= 50)
            {
                toysprice = toysprice - (toysprice * 0.25);
            }
            toysprice = toysprice - (toysprice * 0.10);
            double moneyleft = toysprice - travel;
            if (toysprice >= travel)
            {
                Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(moneyleft):f2} lv needed.");
            }

        }
    }
}