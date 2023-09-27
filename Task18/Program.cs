// Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

string CoordinateRange(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());



string coordinateRange = CoordinateRange(quater);

string result = coordinateRange != null ? $" Заданному номеру четверти соответствует диапазон {coordinateRange}"
                                : $"Введены некоректные координаты";
Console.WriteLine(result);