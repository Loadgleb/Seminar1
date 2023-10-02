// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }

Console.WriteLine("Введите чиcло");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(number);
Console.WriteLine($"{number} -> {result} ");