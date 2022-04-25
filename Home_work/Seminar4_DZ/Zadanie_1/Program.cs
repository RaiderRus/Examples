// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
double numberA = Convert.ToDouble(Console.ReadLine());      // именование в данном случае без смысла, но согласно условию)
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Pow(numberA, numberB);

double Pow(double num, double degree)       // в функции я уже использовал именование, несущее смысл
{
    double pow = 1;

    for (int i = 0; i < degree; i++)
    {
        pow *= num;
    }
    Console.WriteLine(pow);
    return pow;
}