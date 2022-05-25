﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

PrintNumbers(number, count);

void PrintNumbers(int number, int count)
{
    if (number >= count)
    {
        Console.Write(number);
        number--;
        if (number >= count)
        {
            Console.Write(", ");
        }
        PrintNumbers(number, count);
    }
}
