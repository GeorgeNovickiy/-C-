// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNum = Convert.ToInt32(Console.ReadLine());

Div(firstNum, secondNum);


void Div(int Num1, int Num2)
{
    int result = Num1 % Num2;
    if (result == 0) System.Console.WriteLine($"Число {Num1} кратно {Num2}");
    else System.Console.WriteLine($"Число {Num1} не кратно {Num2}, остаток от деления равен {result}");
}
