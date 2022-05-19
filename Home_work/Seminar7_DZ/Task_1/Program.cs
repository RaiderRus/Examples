// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = NumberCheck("Введите количество строк");
int n = NumberCheck("Введите количество столбцов");
Random random = new Random();

double[,] arrayTable = FillArray(m, n);
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

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    int min = -10;
    int max = 10;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * (max - min) + min;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}