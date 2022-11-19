using System;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from the keyboard");

            int n = int.Parse(Console.ReadLine()!);
            int counter = 0;
            // for (int i = 0; i <= n; i++)
            // {
            //     Console.WriteLine($"Number = {i}");
            // }
            // while (counter < n)
            // {
            //     Console.WriteLine($"Number = {counter}");
            //     counter++;
            // }
            do   // В любом случае делает одну итерацию
            {
                Console.WriteLine($"Number = {counter}");
                counter++;
            }
            while (counter < n);
        }
    }

}