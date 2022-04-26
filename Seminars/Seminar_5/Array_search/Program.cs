// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] numbers = new int[6];
FillArray(numbers);
WriteArray(numbers);
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    if (a == numbers[i])
    {
        Console.Write($"Число {a} присутствует в массиве.");
        return;
    }
}
Console.Write($"Число {a} отсутствует в массиве.");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент № " + (i + 1) + ": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}