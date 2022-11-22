using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double groups = double.Parse(Console.ReadLine());

            double Musala = 0;

            double Monblan = 0;

            double Kilimandjaro = 0;

            double K2 = 0;

            double Everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                double peopleInGroups = double.Parse(Console.ReadLine());
                if (peopleInGroups <= 5)
                {
                    Musala += peopleInGroups;
                }
                else if (peopleInGroups >= 6 && peopleInGroups <= 12)
                {
                    Monblan += peopleInGroups;
                }
                else if (peopleInGroups >= 13 && peopleInGroups <= 25)
                {
                    Kilimandjaro += peopleInGroups;
                }
                else if (peopleInGroups >= 26 && peopleInGroups <= 40)
                {
                    K2 += peopleInGroups;
                }
                else if (peopleInGroups >= 41)
                {
                    Everest += peopleInGroups;
                }
            }
            double sum = Musala + Monblan + Kilimandjaro + K2 + Everest;

            Console.WriteLine($"{Musala / sum * 100:f2}%");

            Console.WriteLine($"{Monblan / sum * 100:f2}%");

            Console.WriteLine($"{Kilimandjaro / sum * 100:f2}%");

            Console.WriteLine($"{K2 / sum * 100:f2}%");

            Console.WriteLine($"{Everest / sum * 100:f2}%");
        }
    }
}