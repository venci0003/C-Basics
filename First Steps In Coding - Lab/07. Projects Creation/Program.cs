using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectsName = Console.ReadLine();

            int projectsAmount = int.Parse(Console.ReadLine());

            int hoursNeedeForOneProject = projectsAmount * 3;

            Console.WriteLine($"The architect {architectsName} will need {hoursNeedeForOneProject} hours to complete {projectsAmount} project/s.");
        }
    }
}
