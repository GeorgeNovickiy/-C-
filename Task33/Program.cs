// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] arr = new int[size]; // по умолчанию создается массив размером size, заполненный нулями.
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);

bool FindNumberArray(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
    }
    return false;
}

Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданнео число присутствует в массиве?");
Console.WriteLine(FindNumberArray(array, number) ? "да" : "нет");