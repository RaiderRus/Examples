// Цикл For()

string Method4(int count, string text)
{
    string result = String.Empty; // Пустая строка
    for (int i = 0; i < count; i++) // Параметры перечисляются через ";"
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Текст ");
Console.WriteLine(res);


// Цикл в цикле

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}