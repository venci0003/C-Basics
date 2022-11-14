using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());

            int paint = int.Parse(Console.ReadLine());

            int paintThinner = int.Parse(Console.ReadLine());

            int workersHours = int.Parse(Console.ReadLine());

            double nylonSum = (nylon + 2) * 1.50;

            double paintPercentage = (paint * 0.10);

            double paintSum = (paint + paintPercentage) * 14.50;

            double paintThinnerSum = paintThinner * 5.00;

            double everythingSum = nylonSum + paintSum + paintThinnerSum + 0.40;

            double workersHoursSum = (everythingSum * 0.30) * workersHours;

            double result = everythingSum + workersHoursSum;

            Console.WriteLine(result);
        }
    }
}
