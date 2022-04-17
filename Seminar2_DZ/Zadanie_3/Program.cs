// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Weekend(number);

void Weekend(int number)
{
    if (number < 6 && number > 0)
    {
        Console.WriteLine("Нет, этот день недели не является выходным.");
    }
    if (number > 5 && number < 8)
    {
        Console.WriteLine("Да, этот день недели является выходным.");
    }
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Некорректный ввод.");
    }
}
