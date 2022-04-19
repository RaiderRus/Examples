// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите число: ");
int numberInt = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(numberInt);        // Знаю, что можно было сразу считать строку, но в задании было слово "число" ))

Palindrom(number);

string Palindrom(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("Да, число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Нет, число не является палиндромом.");
    }
    return num;
}