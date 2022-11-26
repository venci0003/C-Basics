using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedBadGrades = int.Parse(Console.ReadLine());

            int grade;

            string lastProblem = string.Empty;

            double gradeSum = 0;

            int failedCounter = 0;

            int gradeCounter = 0;

            string input = Console.ReadLine();

            while (input != "Enough")
            {
                lastProblem = input;

                grade = int.Parse(Console.ReadLine());

                gradeSum += grade;

                gradeCounter++;

                if (grade <= 4)
                {
                    failedCounter++;
                    if (failedCounter == allowedBadGrades)
                    {
                        Console.WriteLine($"You need a break, {failedCounter} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (failedCounter != allowedBadGrades)
            {
                double averageGrade = gradeSum / gradeCounter;
                Console.WriteLine($"Average score: {averageGrade:f2}" +
                    $"\nNumber of problems: {gradeCounter}" +
                    $"\nLast problem: {lastProblem}");
            }
        }
    }
}