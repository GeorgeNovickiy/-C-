// Задача 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 --> {number}");
Console.WriteLine(KillSecondDigit(number));

int KillSecondDigit(int num)
{
    int fitstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = fitstDigit * 10 + thirdDigit;
    return result;
}
