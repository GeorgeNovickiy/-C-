// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int div = a % 2;

if (div == 0)
{
    Console.WriteLine("Число является четным.");
}
else
{
    Console.WriteLine("Число не является четным.");
}
