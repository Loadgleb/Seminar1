// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



// using Internal;

// Math.Pow(3, 6);
// Math.Sqrt(5);

// double d = 5.5843273242;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);

// Console.WriteLine(dRound);

double FindDistance(int ax, int ay, int bx, int by)
{
    int leg1 = ax - bx;
    int leg2 = ay - by;
    double res = Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
    return res;
}

Console.WriteLine("Введите координаты точки А");
Console.Write("X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);


