using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;

            double volumeInLiters = volume / 1000;

            double busy = percentage / 100;

            double liters = volumeInLiters * (1 - busy);
            Console.WriteLine(liters);
        }
    }
}
