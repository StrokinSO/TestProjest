﻿// 12. Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введит первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введит второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Multiplicity(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
    Console.WriteLine($"{num1} кратно {num2}");
    else
    Console.WriteLine($"Остаток {arg1 % arg2}");
}
Multiplicity(num1, num2);