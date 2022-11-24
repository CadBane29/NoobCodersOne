// 0. Демонстрация решения
// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9
// -7 -> 49
int num = 0;

int Input(int num)
{
    num = -1;
    while (num <= 0)
    {
        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num <= 0) num = -num;
    }
    return num;
}

int Output(int number)
{
    int result = number * number;
    return result;
}

int input = Input(num);
int output = Output(input);
Console.WriteLine(output);
