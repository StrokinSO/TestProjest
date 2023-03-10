// 32. Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]

int[] arr = CreateArrayRndInt(10, -50, 50);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine();
InvertArray(arr);
PrintArray(arr);

void InvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
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