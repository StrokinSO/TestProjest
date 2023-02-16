// 65. Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числы в промежутке от M до N.
// M = 1; N = 5 -> "1,2,3,4,5"
// M = 4; N =8 -> "4,5,6,7,8"

Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int numM, int numN)
{
    if(numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbers(numM - 1, numN);
    }
    else Console.WriteLine(numN);    
}