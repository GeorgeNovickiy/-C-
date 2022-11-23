// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1=:");
int x1 = Convert.ToInt32(Console.ReadLine());  
Console.Write("y1=:");
int y1 = Convert.ToInt32(Console.ReadLine());  
Console.Write("z1=:");
int z1 = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2=:");
int x2 = Convert.ToInt32(Console.ReadLine());  
Console.Write("y2=:");
int y2 = Convert.ToInt32(Console.ReadLine());  
Console.Write("z2=:");
int z2 = Convert.ToInt32(Console.ReadLine()); 

double Distance(int x11, int x22, int y11, int y22, int z11, int z22)
{
    return Math.Sqrt(((x11-x22)*(x11-x22)+(y11-y22)*(y11-y22)+(z11-z22)*(z11-z22)));
}

double distance = Math.Round(Distance(x1,x2,y1,y2, z1, z2),2,MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {distance}");
