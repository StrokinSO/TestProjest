// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Задайте координату b1 для первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату k1 для первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату b2 для второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату k2 для второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = 0;
int y = 0;

int[] IntersectionPoint = finalCoordinates(b1,k1,b2,k2,x,y);
printArray(IntersectionPoint);


int[] finalCoordinates(int b1, int k1, int b2, int k2, int x, int y)

{
    int[] result = new int[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = (k1 * (b2 - b1)) / (k1- k2) + b1;
    return result; 
}