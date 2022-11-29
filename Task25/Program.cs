// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());

int Exp(int num, int exp)
{
    int result = num;
    for (int i = 2; i <= exp; i++)
    {
        result = result * num;
    }
    return result;
}

 Console.WriteLine($"Число {A} в степени {B} = {Exp(A,B)}");
