// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int m = NumberCheck("Введите индекс строки");
int n = NumberCheck("Введите индекс столбца");

int[,] arrayTable = new int[4, 3];

FillArray(arrayTable);
PrintArray(arrayTable);

if (m > arrayTable.GetLength(0) - 1 || n > arrayTable.GetLength(1) - 1) Console.WriteLine("Данный элемент отсутствует.");
else Console.WriteLine($"Элемент c индексом {m} {n} равен {arrayTable[m, n]}");

int NumberCheck(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 0)
    {
        Console.WriteLine("Введенное число не является натуральным, повторите попытку ввода");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < arrayTable.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTable.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99);
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
