using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int currentNum = 1;
            for (int i = 1; i <= loops; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;
                    if (currentNum > loops)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNum > loops)
                {
                    break;
                }
            }
        }
    }
}