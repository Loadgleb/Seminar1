// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int num)
{
    int result = (num % 100) / 10;
    return result;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int result = SecondNumber(number);
Console.WriteLine($"Вторая цифра в числе {number} -> {result}");
