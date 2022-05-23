// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayTable = new int[m, n];

FillArray(arrayTable);
PrintTable(arrayTable);
FindMinSumRow(arrayTable);

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintTable(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],-5}");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],-5}");
    }
    Console.WriteLine();
}

void FindMinSumRow(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i] += array[i, j];
        }
    }
    Console.WriteLine("\nСумма строк в массиве");
    PrintArray(arr);
    int min_SumIndex = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min_SumIndex) min_SumIndex = i;
    }
    Console.WriteLine("\nИндекс строки с наименьшей суммой = " + min_SumIndex);
}