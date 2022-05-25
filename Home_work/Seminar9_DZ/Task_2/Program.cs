// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int summ = 0;

if (numberM < numberN)
{
    summ = SummNumbers(numberM, numberN);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна {summ}");
}
else
{
    summ = SummNumbers(numberN, numberM);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberN} до {numberM} равна {summ}");
}

int SummNumbers(int numberM, int numberN)
{
    summ += numberM;
    if (numberM == numberN) return summ;
    return SummNumbers(++numberM, numberN);
}
