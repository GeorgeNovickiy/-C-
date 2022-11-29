// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



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

int[] MultArray(int[] arr)
{
    int[] arr1 = arr.Length % 2 == 0 ? new int[arr.Length / 2] : new int[arr.Length / 2 + 1];
    if (arr.Length % 2 == 0)
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = arr[i] * arr[arr.Length-i-1];
    }
    else 
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = arr[i] * arr[arr.Length-i-1] + arr[arr.Length/2+1];
    }
    return arr1;
}

int[] array2 = MultArray(array);
PrintArray(array2);