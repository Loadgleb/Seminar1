// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Holyday(int num)
{
    {
        string isWeekend = IsWeekend(dayOfWeek) ? "да" : "нет";

        Console.WriteLine($" {dayOfWeek}");
    }

    static bool IsWeekend(int dayOfWeek)
    {
        // Проверяем, является ли день субботой (6) или воскресеньем (7)
        return dayOfWeek == 6 || dayOfWeek == 7;
    }
}

Console.WriteLine("Введите номер дня недели (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());


int dayOfWeek = Holyday(number);
Console.WriteLine($"Третья цифра в числе {number} -> {dayOfWeek}");