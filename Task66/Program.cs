// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Ввведите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sumNaturalNumbers = SumNaturalNumbers(number1, number2);

Console.WriteLine($"Сумма натуральный элементов в промежутке от {number1} до {number2} = {sumNaturalNumbers}");

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numN;
    return numM + SumNaturalNumbers(numM + 1, numN);
}