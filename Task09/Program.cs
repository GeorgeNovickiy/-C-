// 9. Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99] и 
// 2. показывает  наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");

// int fitstDigit = number / 10;
// int secondtDigit = number % 10;

// if (fitstDigit > secondtDigit) Console.WriteLine($"Наибольшая цифра числа --> {fitstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondtDigit}");


int MaxDigit(int num)
{
    int fitstDigit = num / 10;
    int secondtDigit = num % 10;
    if (fitstDigit > secondtDigit) return fitstDigit;
    else return fitstDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");