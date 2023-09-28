// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int res = 1; 
    for (int i = 1; i <= num; i++)
    {
        checked
        {

            res *= i;
        }
        
    }
    return res;
}

Console.WriteLine("Введите целое положительное чило");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел {number} -> {factorial} ");