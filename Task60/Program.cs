// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int line)
{
    int[,,] matrix = new int[rows, columns, line];
    Random rnd = new Random();
    int count = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (count < 100)
                {
                    matrix[i, j, k] = count;
                    count++;
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1)
                    Console.Write($"{matrix[i, j, k],4}({i},{j},{k})");
                else Console.Write($"{matrix[i, j, k],4}({i},{j},{k})");
            }
        }
        Console.WriteLine(endRow);
    }
}

int[,,] Matrix1 = CreateMatrixRndInt(3, 3, 3);
PrintMatrix(Matrix1, "", "", "");
Console.WriteLine();