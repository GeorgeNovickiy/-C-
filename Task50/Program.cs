// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Метод создания массива
{
    int[,] matrix = new int[rows, columns]; // по умолчанию создается массив размером size, заполненный нулями.
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int FindElemMatrix(int[,] matrix, int row, int column)
{
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1)) return matrix[row, column];
    else return -1;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 50);

Console.Write("Введите номер строки: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numColumn = Convert.ToInt32(Console.ReadLine());

int elemMatr = FindElemMatrix(array2D, numRow, numColumn);
if (elemMatr > 0) Console.WriteLine($"Значение искомого элемента равно:{elemMatr}");
else Console.WriteLine("Элемента с указанным индексом нет.");
Console.WriteLine();
PrintMatrix(array2D);