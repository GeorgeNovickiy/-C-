// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] InputNumbers(int numOfNumbers)
{
    int[] num = new int[numOfNumbers];
    for (int i = 0; i < numOfNumbers; i++)
    {
        Console.Write($"Введите {i+1} число:");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int NumAboveZero(int[] ArrayNum)
{
    int count = 0;
    for (int i = 0; i < ArrayNum.Length; i++)
    {
        if (ArrayNum[i] > 0) count++;
    }
    return count;
}


Console.Write("Введите количество чисел :");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrOfNum = InputNumbers(M);
int result = NumAboveZero(arrOfNum);
Console.WriteLine($"Количество чисел больше нуля = {result}");
