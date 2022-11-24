// 5. Напишите программу, которая на 
// 1. вход принимает одно число (N), а на 
// 2. выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

int numN = 0;

int Input(int num)
{
    while (num <= 0)
    {
        Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 0) Console.WriteLine("Enter another number!");
    }
    return num;
}

void Output(int numb)
{
    int i = numb * -1;
    while (numb != i)
    {
        Console.Write($"{i}, ");
        i++;
    }
}

int input = Input(numN);
Output(input);
Console.Write(input);
