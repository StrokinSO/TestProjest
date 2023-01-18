//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rem = 1;

if (rem == 1)
{
    rem += 1;
}
while (rem <= num)
{
    Console.Write(rem + " , ");
    rem += 2;
}
