// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max) // Метод создания массива
{
    double[] arr = new double[size]; // по умолчанию создается массив размером size, заполненный нулями.
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(min, max + 1) / 10.0);
    }
    return arr;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DiffValMaxMin(double[] array)
{
    double min=array[0];
    double max=array[0];
    double result=0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
    }
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
    }
    result = max - min;
    result = Math.Round (result, 1, MidpointRounding.AwayFromZero);
    return result;
}

double[] array = CreateArrayRndDouble(6, 100, 1000);
PrintArray(array);
double diffMaxMin = DiffValMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diffMaxMin}");
