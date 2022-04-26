// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[len];
FillArray(numbers);
WriteArray(numbers);
int lenSum;
if (len % 2 == 0)
{
    lenSum = len / 2;
}
else
{
    lenSum = (len / 2) + 1;
}
int[] sumArr = new int[lenSum];

for (int i = 0; i < sumArr.Length - 1; i++)
{
    sumArr[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
if (len % 2 != 0)
{
    sumArr[sumArr.Length - 1] = numbers[sumArr.Length - 1];
}
WriteArray(sumArr);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
        // Console.Write(array[i] + " ");
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