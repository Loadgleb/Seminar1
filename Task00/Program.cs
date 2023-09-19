// 0. Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).
// 3. Вывод результата 

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

using System.Net.Http.Json;

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

//Console.WriteLine(number + " -> " + square);
Console.WriteLine($"{number} -> {square}");