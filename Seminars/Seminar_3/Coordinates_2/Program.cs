Console.Write("X: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

if (quarterNumber <= 0 || quarterNumber > 4)
{
    Console.WriteLine("Введена неверная четверть, введите число от 1 до 4");
    return;
}

int minX = 0;
int minY = 0;
int maxX = 0;
int maxY = 0;

if (quarterNumber == 1)
{
    minX = 1;
    minY = 1;
    maxX = Int32.MaxValue;
    maxY = Int32.MaxValue;
}
if (quarterNumber == 2)
{
    minX = Int32.MinValue;
    minY = 1;
    maxX = -1;
    maxY = Int32.MaxValue;
}
if (quarterNumber == 3)
{
    minX = Int32.MinValue;
    minY = Int32.MaxValue;
    maxX = -1;
    maxY = -1;
}
if (quarterNumber == 4)
{
    minX = 1;
    minY = Int32.MinValue;
    maxX = Int32.MaxValue;
    maxY = -1;
}


Console.WriteLine($"Диапазон x возможен от {minX} до {maxX}");
Console.WriteLine($"Диапазон y возможен от {minY} до {maxY}");
