// 69. Напишите программу, которая на хвод принимает два числа A и B
// и возводит число A в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

Console.Write("Ввведите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int degreeOfNumber = DegreeOfNumber(number1, number2);

Console.WriteLine($"{number1} в степени {number2} = {degreeOfNumber}");

int DegreeOfNumber(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * DegreeOfNumber(num1, num2 - 1);
}