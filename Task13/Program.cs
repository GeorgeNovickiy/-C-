// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("В числе нет третьей цифры.");
}
else Console.WriteLine($"Третья цифра числа: {ThirdDigitNum(number)}");

int ThirdDigitNum(int num1)
{
    int result = 0;
    if (num1 > 1000)
    {
        while (num1 > 1000)
        {
            num1 = num1 / 10;
        }
        result = num1 % 10;
    }
    else if ((num1 >= 100) && (num1 < 1000)) result = num1 % 10;
    return result;
}
