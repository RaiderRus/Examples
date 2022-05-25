// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана: A({numberM}, {numberN}) равна {AckermanFunc(numberM, numberN)}");

int AckermanFunc(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if ((numberM != 0) && (numberN == 0))
        return AckermanFunc(numberM - 1, 1);
    else
        return AckermanFunc(numberM - 1, AckermanFunc(numberM, numberN - 1));
}
