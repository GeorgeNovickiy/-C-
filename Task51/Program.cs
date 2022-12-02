// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


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

int SumElemDiag(int[,] matrix)
{
    int sumElemDiag = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sumElemDiag = sumElemDiag + matrix[i, j];
        }
    }
    return sumElemDiag;
}

int[,] array = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array);
int result = SumElemDiag(array);
Console.WriteLine($"Сумма элементов находящихся на главной диагонали матрицы равна {result}");
