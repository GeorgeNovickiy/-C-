// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

string ConvertToBin(int num)
{
    string str = string.Empty;
    while (num > 0)
    {
        str = num % 2 + str;
        num = num / 2;
    }
    return str;
}

string newNumberBin = ConvertToBin(number);
Console.WriteLine($"Преобразованное двоичное число равно {newNumberBin}");