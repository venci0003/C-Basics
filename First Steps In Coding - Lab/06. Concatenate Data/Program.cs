using System;

namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();

            string lastName = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string townName = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {townName}.");
        }
    }
}
