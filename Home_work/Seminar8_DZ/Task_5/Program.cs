﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[2, 2, 3] { { { 13, 52, 43 }, { 74, 65, 16 } },
                                       { { 74, 82, 19 }, { 10, 15, 99 } } };

PrintMultiArray(array);

void PrintMultiArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"индекс строки: {i}; индекс столбца: {j}; индекс ширины: {k}");
                Console.WriteLine($"число - {array[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}