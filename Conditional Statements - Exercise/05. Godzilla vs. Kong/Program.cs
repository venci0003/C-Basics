using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());


            double decor = budget * 0.10;
            double clothesprice = statist * clothes;

            if (statist > 150)
            {
                clothesprice = clothesprice - (0.10 * clothesprice);
            }

            double totalmoney = clothesprice + decor;
            double moneyleft = budget - totalmoney;

            if (totalmoney > budget)
            {

                Console.WriteLine($"Not enough money!\nWingard needs {Math.Abs(moneyleft):f2} leva more.");
            }
            else if (budget >= totalmoney)
            {

                Console.WriteLine($"Action!\nWingard starts filming with {moneyleft:f2} leva left.");
            }
        }
    }
}