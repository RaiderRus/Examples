Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int minus_n = -n;

while (minus_n <= n)
    {Console.Write(minus_n);
    minus_n += 1;
    if (minus_n <= n)
    {
    Console.Write(", ");
    }
    }