// 67. Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифрю
// 453 -> 12
// 45 -> 9

Console.Write("Ввведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);

Console.WriteLine($"Сумма цифр числа {number} = {sumNumbers}");

int SumNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumNumbers(num / 10);
}