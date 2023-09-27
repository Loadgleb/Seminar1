// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    if (num < 100 || num > 999)
    {
        Console.WriteLine("Ошибка: число не является трехзначным");
        return -1;
    }
    int thirdDigit = num  % 10;
    if (thirdDigit == 0)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    return thirdDigit;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int thirdDigit = ThirdDigit(number);
Console.WriteLine($"Третья цифра в числе {number} -> {thirdDigit}");
