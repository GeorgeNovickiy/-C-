// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны треугольника:");
int firstLine = Convert.ToInt32(Console.ReadLine());        
Console.WriteLine("Введите длину второй стороны треугольника:");
int secondLine = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите длину третей стороны треугольника:");
int thirdLine = Convert.ToInt32(Console.ReadLine());  

bool Triangle(int a, int b, int c)
{
    if ((a+b) > c && (a+c) > b && (c+b) > a) return true;
    else return false;
}

bool tri = Triangle(firstLine, secondLine, thirdLine);
Console.WriteLine(tri ? "да" : "нет");