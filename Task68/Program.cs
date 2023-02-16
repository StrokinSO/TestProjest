// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Ввведите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ack = Ack(number1, number2);

Console.WriteLine($"Функция Аккермана для чисел A({number1},{number2}) = {ack}");

int Ack(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Ack(M - 1, 1);
    if (M > 0 && N > 0) return Ack(M - 1, Ack(M, N - 1));
    return Ack(M, N);
}