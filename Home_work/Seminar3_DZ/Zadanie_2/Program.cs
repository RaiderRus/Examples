// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double x1 = Coordinate("x", "A");
double y1 = Coordinate("y", "A");
double z1 = Coordinate("z", "A");
double x2 = Coordinate("x", "B");
double y2 = Coordinate("y", "B");
double z2 = Coordinate("z", "B");

double Coordinate(string coordName, string pointName)   // Идея для функции позаимствована из семинара)
{
    Console.Write($"Введите координату {coordName} точки {pointName}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками равно {Math.Round(distance, 2)}");     // Не уверен, что можно использовать Math.Round(), но с ней как то лучше ответ смотрится)
