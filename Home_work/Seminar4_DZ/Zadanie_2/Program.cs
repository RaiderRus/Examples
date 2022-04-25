// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SumDigit(number);

int SumDigit(int num)
{
    int total = 0;
    while (num != 0)
    {
        int lastDigit = num % 10;    // вычисляем последнюю цифру числа
        total += lastDigit;             // суммируем ее с переменной total
        num = num / 10;           // отрезаем у числа одну цифру
    }
    Console.WriteLine(total);
    return total;
}