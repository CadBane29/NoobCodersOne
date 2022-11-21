// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num = -1;

// while (num < 10000 || num > 99999)
// {
//     Console.WriteLine("Enter number: ");
//     num = Convert.ToInt32(Console.ReadLine());
//     if (num < 10000 || num > 99999) Console.WriteLine("Enter another number, your number is uncorrect!");
// }

// int Digit(int n)
// {
//     int firstDigit = n / 10000;
//     int secondDigit = n / 1000 % 10;
//     int thirdDigit = n / 100 % 10;
//     int fourthDigit = n / 10 % 10;
//     int fiveDigit = n % 10;
//     return fiveDigit * 10000 + fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit;
// }
// int result = Digit(num);
// if(result == num) Console.WriteLine($"Your number {num} is a palindrome of number {result}.");
// else Console.WriteLine($"Number {result} is not a palindrome of number {num}!");

// int InputNumber()
// {
//     int num = 0;
//     while (num < 10 && num > -10)
//     {
//         Console.Write("Введите целое число: ");
//         num = Convert.ToInt32(Console.ReadLine());
//         if (num < 10 && num > -10) Console.WriteLine("Для палиндрома нужно хотя бы двузначное число.\n");
//     }
//     return num;
// }

// int Reverse(int num)
// {
//     int rev = 0;
//     while (num != 0)
//     {
//         rev = rev * 10 + num % 10;
//         num /= 10;
//     }
//     return rev;
// }

// bool CheckPalindrome(int num)
// {
//     int rev = Reverse(num);
//     return num == rev;
// }

// void Output()
// {
//     int num = InputNumber();
//     if (CheckPalindrome(num)) Console.WriteLine($"{num} -> да");
//     else Console.WriteLine($"{num} -> нет");
// }

// Output();

int InputNumber()
{
    int num = 0;
    while (num < 10 && num > -10)
    {
        Console.Write("Enter an intenger: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num < 10 && num > -10) Console.WriteLine("A palindrome requires at least a two-digit number! \n");
    }
    return num;
}

int Reverse(int num)
{
    int rev = 0;
    while (num != 0)
    {
        rev = rev * 10 + num % 10;
        num /= 10;
    }
    return rev;
}

bool CheckPalindrome(int num)
{
    int rev = Reverse(num);
    return num == rev;
}

void Output()
{
    int num = InputNumber();
    if (CheckPalindrome(num)) Console.WriteLine($"{num} -> Yes!");
    else Console.WriteLine($"{num} -> Nope!");
}

Output();