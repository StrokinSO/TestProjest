﻿// 28. Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int theProductOfNumbers = TheProductOfNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {theProductOfNumbers}");

int TheProductOfNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked //проверка на переполнение
        {
             mult = mult * i;
        }
       
    }
    return mult;
}