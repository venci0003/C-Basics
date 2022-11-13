using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideInput = double.Parse(Console.ReadLine());

            double cm = sideInput * 2.54;

            Console.WriteLine(cm);
        }
    }
}
