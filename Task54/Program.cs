// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortElemInRow(int[,] matrix)
{
    int maxElem;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int indexMax = 0;
        while (indexMax < matrix.GetLength(1))
        {
            maxElem = matrix[i, indexMax];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (maxElem < matrix[i, j])
                {
                    matrix[i, indexMax] = matrix[i, j];
                    matrix[i, j] = maxElem;
                    maxElem = matrix[i, indexMax];
                }
            }
            indexMax++;
        }
    }
    return matrix;
}

void ReverseRowInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) / 2; j++)
        {       
            int temp = matrix[i,j];
            matrix[i,j] = matrix[i,matrix.GetLength(1) - 1 - j];
            matrix[i,matrix.GetLength(1) - 1 - j] = temp;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 99);
PrintMatrix(array2D, "", "", "");
Console.WriteLine();

int[,] sortElemInRowInArray2D = SortElemInRow(array2D);
ReverseRowInMatrix(sortElemInRowInArray2D);
PrintMatrix(sortElemInRowInArray2D, "", "", "");

