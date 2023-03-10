// 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
// последний элемент, второй и предпоследний и т.д. Результат записываем в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
int[] newArr = TwoNumbersMultiply(arr);
Console.Write("\r\nНовый массив: ");
PrintArray(newArr);


int[] TwoNumbersMultiply(int[] massive)
{
    int size = massive.Length/2;
    if (massive.Length % 2 == 1) size +=1;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = massive[i] * massive[massive.Length - 1 - i];
    }
    if (massive.Length % 2 == 1) newArray[size -1] = massive[massive.Length / 2];
    return newArray;
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