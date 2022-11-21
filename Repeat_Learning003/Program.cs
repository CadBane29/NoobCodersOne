// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// int n = -1;
// int i = 1;

// while (n < 1)
// {
//     Console.WriteLine("Enter the number from 1: ");
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n < 1) Console.WriteLine("Enter another number!");
// }

// void NumberN(int num)
// {
//     Console.WriteLine($"{num} -> ");
//     while(i <= num)
//     {
//         Console.WriteLine($"{i} | {i * i * i}");
//         i++;
//     }
// }
// NumberN(n);


// int InputNumber()
// {
//     Console.Write("Please, enter a positive integer: ");
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     if (num == 0) Console.WriteLine("Enter another number!");
//     return num;
// }

// void OutPut(int num)
// {
//     for(int count = 1; count <= num; count++)
//     {
//         double pow = Math.Pow(count, 3);
//         Console.WriteLine($"{count} | {pow}");
//     }
// }

// int number = InputNumber();

// OutPut(number);

// int InputNumber()
// {
//     Console.Write("Please, enter a positive integer: ");
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     if (num == 0) Console.WriteLine("Enter another number!");
//     return num;
// }

// void OutPut(int num)
// {
//     for(int count = 1; count <= num; count++)
//     {
//         double pow = Math.Pow(count, 3);
//         Console.WriteLine($"{count} | {pow}");
//     }
// }

// int number = InputNumber();

// OutPut(number);

// Произвольная степень:

// int InputNumber(string message)
// {
//     Console.Write(message);
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     if (num == 0) Console.WriteLine("Ener another number!");
//     return num;
// }

// void OutPut(int num, int pow)
// {
//     for(int count = 1; count <= num; count++)
//     {
//         double calc = Math.Pow(count, pow);
//         Console.WriteLine($"{count} | {calc}");
//     }
// }

// int number = InputNumber("Please, enter a positive integer: ");
// int power = InputNumber("Enter, what degree you want to raise: ");

// OutPut(number, power);

int InputNumber()
{
    Console.WriteLine("Enter the number: ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (num == 0) Console.WriteLine("Enter another number!");
    return num;
}

void OutPut(int num1)
{
    for(int count = 1; count <= num1; count++)
    {
        double pow = Math.Pow(count, 3);
        Console.WriteLine($"{count} | {pow}");
    }
}

int number = InputNumber();
OutPut(number);