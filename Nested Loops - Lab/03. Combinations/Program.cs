using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int firstNumber = 0; firstNumber <= loops; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= loops; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= loops; thirdNumber++)
                    {
                        if (firstNumber + secondNumber + thirdNumber == loops)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
