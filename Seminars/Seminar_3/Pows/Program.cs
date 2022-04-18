Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    Console.Write($"{count * count} ");
    count++;
}