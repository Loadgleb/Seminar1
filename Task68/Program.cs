// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите неотрицательное целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int result = CalculateAckermanFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");


static int CalculateAckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return CalculateAckermanFunction(m - 1, 1);
    if (m > 0 && n > 0)
        return CalculateAckermanFunction(m - 1, CalculateAckermanFunction(m, n - 1));

    return 0;
}
