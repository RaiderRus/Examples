// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заполнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

Console.WriteLine("Введите числа через запятую: ");
string strNumbers = Console.ReadLine();

string strArray = String.Empty;

string[] arrayNumbers = new string[8];

RemoveChar(strNumbers);
// FillArray(arrayNumbers);
PrintArray(arrayNumbers);

string RemoveChar(string list)
{
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] != ',' || list[i] != ' ')
        {
            strArray = strArray + list[i];
        }
    }
    Console.WriteLine(strArray);
    return strArray;
}

// void FillArray(string[] list)
// {
//     for (int i = 0; i < strArray.Length; i++)
//     {
//         arrayNumbers[i] = strNumbers[i];
//     }
// }

void PrintArray(string[] array)
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