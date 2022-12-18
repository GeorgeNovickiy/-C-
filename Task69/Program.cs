// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите первое  число : ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе  число : ");
int B = Convert.ToInt32(Console.ReadLine());


int DegreeNumber(int number, int degree)
{
    if (degree == 0) return 1;
    else 
    return number * DegreeNumber(number,degree-1);
}


Console.WriteLine(DegreeNumber(A,B));