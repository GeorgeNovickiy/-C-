// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число : ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < N) Console.WriteLine($"{SumNumMToN(M, N)}");
else Console.WriteLine($"{SumNumMToN(N, M)}");

int SumNumMToN(int firstNum, int secondNum)
{
    if (firstNum <= secondNum)
    return firstNum + SumNumMToN(firstNum+1,secondNum);
    return 0;
}
