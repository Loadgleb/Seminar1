// 0. Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).
// 3. Вывод результата 

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// using System.Net.Http.Json;

// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int square = number * number;

// //Console.WriteLine(number + " -> " + square);
// Console.WriteLine($"{number} -> {square}");

using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
// Введите свое решение ниже
    int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    public static void SortRowsDescending(int[,] matrix)
    {
// Введите свое решение ниже
        int numRows = matrix.GetLength(0);

        // Создаем массив, в котором будем хранить суммы строк и их индексы
        int[] rowSums = new int[numRows];
        for (int i = 0; i < numRows; i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
          rowSums[i] = sum;
    }
       for (int i = 0; i < numRows - 1; i++)
        {
            for (int j = i + 1; j < numRows; j++)
            {
                if (rowSums[i] < rowSums[j])
                {
                    // Обмен индексов
                    int tempIndex = i;
                    i = j;
                    j = tempIndex;
                }
            }
        }
      int[,] sortedMatrix = new int[numRows, matrix.GetLength(1)];
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sortedMatrix[i, j] = matrix[j, rowSums[i]];
            }
        }
      Array.Copy(sortedMatrix, matrix, sortedMatrix.Length);
    }

// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}