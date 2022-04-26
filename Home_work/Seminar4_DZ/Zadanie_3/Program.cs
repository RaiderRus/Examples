// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заполнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива № " + (i + 1) + ": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)     // Дополнительное ветвление, чтобы убрать лишнюю запятую)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}