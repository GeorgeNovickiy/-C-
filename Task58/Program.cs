// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MultiplMatr(int[,] Matr1, int[,] Matr2)
{
    int[,] Multiple = new int[Matr1.GetLength(0), Matr2.GetLength(1)];
    for (int i = 0; i < Multiple.GetLength(0); i++)
    {
        for (int j = 0; j < Multiple.GetLength(1); j++)
        {
            for (int k = 0; k < Matr2.GetLength(0); k++)
            {
                Multiple[i, j] = Multiple[i, j] + Matr1[i, k] * Matr2[k, j];
            }
        }
    }
    return Multiple;
}

int[,] Matrix1 = CreateMatrixRndInt(2, 2, 1, 9);
int[,] Matrix2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(Matrix1, "", "", "");
Console.WriteLine();
PrintMatrix(Matrix2, "", "", "");
Console.WriteLine();

int[,] MatrixResult = MultiplMatr(Matrix1, Matrix2);
PrintMatrix(MatrixResult, "", "", "");
