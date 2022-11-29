// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {number} ={SumDigit(number)}");


int SumDigit(int num)
{
    int result = 0;
    while (num > 1)
    {
        result = result + (num % 10);
        num = num / 10;
    }
    return result;
}
