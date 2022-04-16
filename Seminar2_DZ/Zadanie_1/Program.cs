// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit = 0;
int count = 0;

int secondDigit = FindSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number}: {secondDigit}");

int FindSecondDigit(int digits)
{
    while(count != 2)
    {
        lastDigit = digits % 10;
        digits = digits / 10;
        count++;         
    }
    return lastDigit;
}
