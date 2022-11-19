using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from the keyboard: ");

            int n = int.Parse(Console.ReadLine()!);
            Console.Write("\n"); // символ переноса на новую строку

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n"); // символ переноса на новую строку
            }
        }
    }
}