int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number1);
// Console.WriteLine(number2);

int ostatok = Ostatok(number1, number2);

if (ostatok == 0)
{
    Console.WriteLine("Является");
}
else
    Console.WriteLine($"Остаток {ostatok}");

int Ostatok(int arg1, int arg2)
{
    int ostatok = arg1 % arg2;
    return ostatok;
}
