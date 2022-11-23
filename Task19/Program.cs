// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if ((9999 < number) && (number < 100000))
{
    if (Palindrome(number)) Console.WriteLine($"Число {number} является палиндромом");
    else Console.WriteLine($"Число {number} не является палиндромом");
}
else Console.WriteLine($"Число {number} не является пятизначным");

bool Palindrome(int num1)
{
    int firstDigit = num1 / 10000;
    int secondDigit = (num1 / 1000) % 10;
    int fourthDigit = (num1 % 100) / 10;
    int fifthDigit = num1 % 10;
    return (firstDigit == fifthDigit) && (secondDigit == fourthDigit);
}