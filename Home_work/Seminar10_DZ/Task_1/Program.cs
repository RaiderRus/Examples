// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все 
// числа в группе друг на друга не делятся)? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰. Можно использовать рекурсию.

Console.Write("Введите N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
int[,] baseArray = new int[NumberN, NumberN];
SimpleNumbersGroup(NumberN, baseArray);
int NumberM = 0;
for (int i = 0; i < baseArray.GetLength(0); i++)
    if (baseArray[i, 0] == 0) break;
    else { NumberM++; }
Console.WriteLine($"Для N = {NumberN}, M получается {NumberM} взаимно простых групп:");
PrintArray(baseArray);

void SimpleNumbersGroup(int n, int[,] baseArray)
{
    bool flag = false;
    for (int k = 1; k <= n; k++)
    {
        flag = false;
        for (int i = 0; i < baseArray.GetLength(0); i++)
        {
            for (int j = 0; j < baseArray.GetLength(1); j++)
            {
                if (baseArray[i, j] == 0)
                {
                    baseArray[i, j] = k;
                    flag = true;
                    break;
                }
                else
                {
                    if (k % baseArray[i, j] == 0) break;
                }
            }
            if (flag) break;
        }
    }
}

void PrintArray(int[,] baseArray)
{
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        if (baseArray[i, 0] == 0) break;
        else
        {
            Console.Write($"Группа {i + 1}: ");
            for (int j = 0; j < baseArray.GetLength(1); j++)
            {
                if (baseArray[i, j] == 0) break;
                else
                    Console.Write($"{baseArray[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}