using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                }
            }
        }
    }
}