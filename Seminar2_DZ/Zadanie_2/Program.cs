// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int lastDigit = 0;

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string numberStr = Convert.ToString(number);    // копируем значение числа в строку для подсчета его длины
int lenNumber = numberStr.Length;   // Выясняем длину числа

if (lenNumber >= 3)
{
    int thirdDigit = FindThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number}: {thirdDigit}");
}
else
    Console.WriteLine("Третьей цифры нет");

int FindThirdDigit(int digits)
{
    while (lenNumber >= 3)
    {
        lastDigit = digits % 10;
        digits = digits / 10;        // Обрезаем число до 3 цифры
        lenNumber -= 1;
    }
    return lastDigit;
}
