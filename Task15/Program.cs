//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
    Console.WriteLine("Не выходной день");
else if (number == 2)
    Console.WriteLine("Не выходной день");
else if (number == 3)
    Console.WriteLine("Не выходной день");
else if (number == 4)
    Console.WriteLine("Не выходной день");
else if (number == 5)
    Console.WriteLine("Не выходной день");
else if (number == 6)
    Console.WriteLine("Выходной");
else if (number == 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Введено некорректное значение");