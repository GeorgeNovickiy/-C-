// Задача 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// ЭТО МОЕ РЕШЕНИЕ
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// SqrTable(number);

// void SqrTable (int num)
// {
//     int count =1;
//     while (count <=num)
//     {
//         Console.WriteLine($"{count}   {count*count}");
//         count++;
//     }
// }

//Это решение Алексея Замараева
int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введеные неверные данные");
}

string SqrTable(int n1)
{
    int count = 1;
    string table = "";
    while (count <= n1)
    {
        table = table + $"{count}|{count * count} \n";
        count++;
    }
    return table;
}

string sqrTable = SqrTable(n);
Console.WriteLine(sqrTable);
