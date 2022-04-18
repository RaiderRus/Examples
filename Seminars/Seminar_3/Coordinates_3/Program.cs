double x1 = Coordinate("x", "A");
double y1 = Coordinate("y", "A");
double x2 = Coordinate("x", "B");
double y2 = Coordinate("y", "B");

double Coordinate(string coordName, string pointName)
{
    Console.Write($"Введите координату {coordName} точки {pointName}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double a = (x2 - x1) * (x2 - x1); // Math.Pow()
double b = (y2 - y1) * (y2 - y1);
double c = a + b;

double distance = Gipotenusa(c);

double Gipotenusa(double sum)
{
    Math.Sqrt(sum);
    return Math.Sqrt(sum);
}

Console.WriteLine($"Расстояние между точками равно {distance}");