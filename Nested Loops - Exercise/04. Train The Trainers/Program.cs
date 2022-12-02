using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            string input = string.Empty;
            double average = 0;
            double totalGrades = 0;
            double totalAverage = 0;
            int counter = 0;
            while (input != "Finish")
            {
                input = Console.ReadLine();
                if (input == "Finish")
                {
                    break;
                }
                for (int i = 1; i <= loops; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                    average = totalGrades / loops;
                }
                Console.WriteLine($"{input} - {average:f2}.");
                totalAverage += average;
                totalGrades = 0;
                average = 0;
                counter++;
            }
            Console.WriteLine($"Student's final assessment is {totalAverage / counter:f2}.");
        }
    }
}
