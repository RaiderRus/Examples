// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int lines = InputNumber("Введите количество строк");
int colomns = InputNumber("Введите количество столбцов");
int[,] arrayTable = new int[lines, colomns];

FillArray(arrayTable, 1, 10);
PrintArray(arrayTable);

for (var i = 0; i < arrayTable.GetLength(0); i++)
{
    int[] tempArray = new int[arrayTable.GetLength(1)];
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        tempArray[j] = arrayTable[i, j];
    }
    tempArray = TableSort(tempArray);

    for (var j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i, j] = tempArray[j];
    }
}

Console.WriteLine("Результат сортировки: ");
PrintArray(arrayTable);

int[] TableSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
        }
    }
    return array;
}

int InputNumber(string output)
{
    Console.Write(output + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] matr, int festNumber, int secondNumber)
{
    for (int lines = 0; lines < matr.GetLength(0); lines++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[lines, columns] = new Random().Next(festNumber, secondNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($" {array[rows, columns]}");
        }
        Console.WriteLine();
    }
}