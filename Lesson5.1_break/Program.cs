using System;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from the keyboard");

            int n = int.Parse(Console.ReadLine()!);
            //int counter = 0;

            // while (true)
            // {
            //     Console.WriteLine($"Meaning counter = {counter}");
            //     counter++;
            //     if (counter > n)
            //     {
            //         break;
            //     }
            // }
            // Console.WriteLine("Arghhh...");
            for (int i = 0;i < n; i++)
            {
                if(i % 2 != 0)
                {    
                    continue;
                }
                Console.WriteLine($"Meaning value = {i}");
            }
        }
    }

}