// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = NumberCheck("Введите количество строк");
int n = NumberCheck("Введите количество столбцов");
Random random = new Random();

double[,] arrayTable = new double[m, n];

FillArray(arrayTable);
PrintArray(arrayTable);

int NumberCheck(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number <= 0)
    {
        Console.WriteLine("Введенное число не является натуральным, повторите попытку ввода");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < arrayTable.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTable.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", array[i, j]);
        }
        Console.WriteLine();
    }
}