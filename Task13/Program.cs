// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;

if (num > 99)
    Console.Write($"Третья цифра числа: {res = num % 10}");

else
    Console.Write("Третьей цифры нет");