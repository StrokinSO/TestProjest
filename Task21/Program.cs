// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1, y1, z1, x2, y2, z2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.Write($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {dRound}");

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int cathet1 = xb - xa;
    int cathet2 = yb - ya;
    int cathet3 = zb - za;
    double result = Math.Sqrt(cathet1 * cathet1 + cathet2 * cathet2 + cathet3 * cathet3);
    return result;
}