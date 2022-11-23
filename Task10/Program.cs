// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());

if ((99 < num1) && (num1 < 1000)) Console.WriteLine($"Третьей цифрой числа {num1} является {SecondDigitNum(num1)}");
else Console.WriteLine($"Число {num1} не является трехзначным");

int SecondDigitNum(int number)
{
    int result = (number % 100) / 10;
    return result;
}