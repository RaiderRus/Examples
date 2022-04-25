// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
double numberA = Convert.ToDouble(Console.ReadLine());
double pow = 1;
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < numberB; i++)
{
    pow *= numberA;
}
Console.WriteLine(pow);