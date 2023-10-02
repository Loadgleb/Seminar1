// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Natural(int a, int b)
{

    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }

    return result;
}

Console.WriteLine("Введите целое число A");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое натуральное число B");
int number2 = Convert.ToInt32(Console.ReadLine());

int natural = Natural(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {natural}");

