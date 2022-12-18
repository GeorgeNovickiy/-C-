// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите первое натуральное число : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число : ");
int N = Convert.ToInt32(Console.ReadLine());

NaturalNumbers1(M,N);
NaturalNumbers2(M,N);

void NaturalNumbers1 (int firstNum,int secondNum)
{
    if (firstNum-1 >= secondNum) return;
    NaturalNumbers1 (firstNum, secondNum - 1);
    Console.Write($"{secondNum} ");
}

void NaturalNumbers2 (int firstNum,int secondNum)
{
    if (firstNum <= secondNum-1) return;
    NaturalNumbers2 (firstNum-1, secondNum);
    Console.Write($"{firstNum} ");
}
