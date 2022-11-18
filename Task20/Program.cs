// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// int n = 12345;
// double res = Math.Sqrt(n);

// double n1 = 5.099985645;
// double nRound = Math.Round(n1, 2, MidpointRounding.ToZero);

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1=:");
int x1 = Convert.ToInt32(Console.ReadLine());  
Console.Write("y1=:");
int y1 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2=:");
int x2 = Convert.ToInt32(Console.ReadLine());  
Console.Write("y2=:");
int y2 = Convert.ToInt32(Console.ReadLine());  

double Distance(int x11, int x22, int y11, int y22)
{
    return Math.Sqrt((x11-x22)*(x11-x22)+(y11-y22)*(y11-y22));
}

double distance = Math.Round(Distance(x1,x2,y1,y2),2,MidpointRounding.ToZero);
Console.WriteLine($"РАсстояние между точками = {distance}");