using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tournamets = int.Parse(Console.ReadLine());

            double pointsGiven = double.Parse(Console.ReadLine());

            double amountOfPoints = 0;

            double counter = 0;

            double finalPoints = 0;

            double averageScore = 0;

            double wins = 0;

            for (int i = 1; i <= tournamets; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    amountOfPoints += 2000;
                    counter++;
                }
                if (stage == "F")
                {
                    amountOfPoints += 1200;
                }
                if (stage == "SF")
                {
                    amountOfPoints += 720;
                }

                finalPoints = amountOfPoints + pointsGiven;

                averageScore = (amountOfPoints / tournamets);

                wins = (counter / tournamets) * 100;
            }


            Console.WriteLine($"Final points: {finalPoints}");

            Console.WriteLine($"Average points: {Math.Floor(averageScore)}");

            Console.WriteLine($"{wins:f2}%");
        }
    }
}