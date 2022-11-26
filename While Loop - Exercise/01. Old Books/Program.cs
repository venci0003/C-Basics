using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = Console.ReadLine();

            int counter = 0;
            while (input != "No More Books")
            {
                if (input == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                input = Console.ReadLine();
                counter++;
            }
            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!\nYou checked {counter} books.");
            }


        }
    }
}