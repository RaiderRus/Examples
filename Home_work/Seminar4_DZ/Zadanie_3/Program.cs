// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Поправка: на семинаре дал добро на заполнение массива рандомными числами. 
// В оригинале нужно пользователю ввести строку - ряд чисел через запятую, 
// а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

Console.Write("Введите числа через запятую: ");
string strNumbers = Console.ReadLine();

int countChar = 1;

CountNumbers(strNumbers);
int[] arrayNumbers = new int[countChar];
FillArray(strNumbers);
PrintArray(arrayNumbers);

void CountNumbers(string numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == ',')
        {
            countChar++;
        }
    }
}

void FillArray(string numbers)
{
    int index = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        string strToIntArray = String.Empty;

        while (numbers[i] != ',')
        {
            if (i != numbers.Length - 1)
            {
                strToIntArray += Convert.ToString(numbers[i]);
                i++;
            }
            else
            {
                strToIntArray += Convert.ToString(numbers[i]);
                break;
            }
        }
        arrayNumbers[index] = Convert.ToInt32(strToIntArray);
        index++;
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
}
