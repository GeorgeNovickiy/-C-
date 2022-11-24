// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumDig(number);
Console.WriteLine($"В числе {number} количество цифр равно {result}");

int NumDig(int num1)
{
    int res = 1;

    while (num1 > 10)
    {
        num1 = num1 / 10;
        res ++;
    }
    while (num1 < -10)
    {
        num1 = num1 / 10;
        res ++;
    }
    return res;
}