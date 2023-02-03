// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = CreateArrayRndInt(4, -99, 99);
PrintArray(arr);

int newArr = SumOfElements(arr);
Console.Write($"\r\nСумма элементов, стоящих на нечётных позициях: {newArr}");


int SumOfElements (int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum+= array[i];
        i += 2;
    }
    return sum;
}

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
      Console.Write("[");
      for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}