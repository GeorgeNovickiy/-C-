// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Введите значение  к1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение  b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение  к2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение  b1:");
double b2 = Convert.ToDouble(Console.ReadLine());

double FindX(double K1, double B1, double K2, double B2)
{
    double x = (B2 - B1) / (K1 - K2);
    return x;
}

double FindY(double x, double K1, double B1)
{
    double y = K1 * x + B1;
    return y;
}

double X = FindX(k1, b1, k2, b2);
double Y = FindY(X, k1, b1);
Console.WriteLine($" Координатами точки пересечения двух прямых являются ({X},{Y})");