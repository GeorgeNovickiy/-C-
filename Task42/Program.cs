// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Решение через строковый тип данных 

// Console.WriteLine("Введите десятичное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// string ConvertToBin(int num)
// {
//     string str = string.Empty;
//     while (num > 0)
//     {
//         str = num % 2 + str;
//         num = num / 2;
//     }
//     return str;
// }

// string newNumberBin = ConvertToBin(number);
// Console.WriteLine($"Преобразованное двоичное число равно {newNumberBin}");


/////////////////////////////////////////////////////////////////

// Решение через массив int

void PrintArray(int[] arr, string beginStr, string separatorElems, string endstr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}


int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while (numb1 > 0)
    {
        numb1 /= 2;
        digits += 1;

    }
    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[bin.Length-i-1] = numb % 2;
        numb /= 2;
    }
    return bin;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
// Console.WriteLine(Binary(number));
PrintArray(binary, "", "", "");
