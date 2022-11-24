// 1. Напишите программу, которая на 
// 1. вход принимает два числа и 
// 2. проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
int numb1 = 0;
int numb2 = 0;

int Input(int num1)
{
    while (num1 <= 0)
    {
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 <= 0) num1 = -num1;
    }
    return num1;
}

int InputSecond(int num2)
{
    while (num2 <= 0)
    {
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 <= 0) num2 = -num2;
    }
    return num2;
}

bool Output(int number1, int number2)
{
    if (number1 == number2 * number2) return true;
    else return false;
}

int input = Input(numb1);
int inputSecond = InputSecond(numb2);
bool output = Output(input, inputSecond);
Console.WriteLine($"a = {input}, b = {inputSecond} -> {output}");