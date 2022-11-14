using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
            if (figures == "square")
            {
                double number = double.Parse(Console.ReadLine());

                Console.WriteLine($"{number * number:f3}");
            }
            else if (figures == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num1 * num2:f3}");
            }
            else if (figures == "circle")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * num * num:f3}");
            }
            else if (figures == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{(num1 * num2) / 2:f3}");
            }

        }
    }
}
