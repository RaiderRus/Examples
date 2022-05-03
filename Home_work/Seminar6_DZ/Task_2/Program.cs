// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите числа: ");
double b1 = Coordinate("b1");
double k1 = Coordinate("k1");
double b2 = Coordinate("b2");
double k2 = Coordinate("k2");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Координаты точки пересечения прямых: x = {x}; y = {y}.");
}

double Coordinate(string numberName)
{
    Console.Write($"Введите число {numberName}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
