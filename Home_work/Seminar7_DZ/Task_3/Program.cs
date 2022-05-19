// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] arrayTable = new int[4, 3];

FillArray(arrayTable);
PrintArray(arrayTable);

double sum = 0;
for (int i = 0; i < arrayTable.GetLength(1); i++)
{
    for (int j = 0; j < arrayTable.GetLength(0); j++)
    {
        sum += arrayTable[j, i];
    }
    Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {Math.Round(sum / 4, 1)}");
    sum = 0;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < arrayTable.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTable.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 99);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
