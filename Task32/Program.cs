// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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

void ReplaceElemsArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=arr[i]*-1;
    }
}

ReplaceElemsArray(array);
PrintArray(array);