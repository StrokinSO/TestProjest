﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int rem = num % 2;

if (rem == 0)
    Console.Write("Является чётным числом");
else
    Console.Write("Не является чётным числом");
