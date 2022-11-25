// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int[] array = CreateArrayRndInt(4, 1, 100);
PrintArray(array);

int CountFindNumberArray(int [] arr, int min, int max)
{
    int count = 0;
    for (int i = min; i < max; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == i) count++;
        }
    }
    return count;
}

int result = CountFindNumberArray(array, 10, 99);
Console.WriteLine($"Количество элементов массива, значения которых лежать в отрезке [10, 99] = {result}");
