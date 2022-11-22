using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            double washingMachine = double.Parse(Console.ReadLine());

            double toysPrice = double.Parse(Console.ReadLine());

            double savedMoney = 0;

            double birthdayMoney = 0;

            double moneyTaken = 0;

            int toys = 0;

            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    birthdayMoney += 10;

                    savedMoney += birthdayMoney;
                    moneyTaken++;
                }
                else
                {
                    toys++;
                }
            }
            double toySum = toys * toysPrice;

            double sum = (toySum + savedMoney) - moneyTaken;
            if (sum >= washingMachine)
            {
                Console.WriteLine($"Yes! {sum - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(washingMachine - sum):f2}");
            }
        }
    }
}