// Задача 55: Задайте двумерный массив. 
// Напишите программу,которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            // TODO: вывести индексы массива.
            // matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}

int[,] ChangeRowsColumns(int[,] matrix)
{
    int[,] tempMatr = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempMatr[i, j] = matrix[j, i];
        }
    }
    return tempMatr;
}

int[,] array = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array, "", "", "");
Console.WriteLine();
if (array.GetLength(0) == array.GetLength(1))
{
    int[,] modifiedMatr = ChangeRowsColumns(array);
    PrintMatrix(modifiedMatr, "", "", "");
}
else Console.WriteLine("Замена невозможна.");


