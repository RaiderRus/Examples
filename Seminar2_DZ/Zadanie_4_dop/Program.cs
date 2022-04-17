// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
// Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

// Настройки игры:
int tryes = 3;  // Количество потыток
int minNumber = 1; // Нижний порог числа
int maxNumber = 1000;   // Верхний порог числа

string userName = "";
int number = 0;

while (tryes != 0)
{
    number = StartGame(number);
    userName = UserName(userName);
    Guess();
    Console.WriteLine($"Хочешь попробовать сыграть еще раз? y/n: ");
    string answer = Console.ReadLine();
    if (answer == "y")
    {
        tryes = 3;
    }
    if (answer == "n")
    {
        Console.WriteLine($"До свидания, {userName}!");
        break;
    }
}

void Guess()
{
    tryes = 3;

    while (tryes != 0)
    {
        Console.WriteLine($"У вас осталось {tryes} попытки.");
        Console.WriteLine("Введите число: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        tryes -= 1;
        if (userNumber > number)
        {
            Console.WriteLine($"Не правильно {userName}! Загаданное число меньше, чем {userNumber}");
        }
        if (userNumber < number)
        {
            Console.WriteLine($"Не правильно {userName}! Загаданное число больше, чем {userNumber}");
        }
        if (userNumber == number)
        {
            Console.WriteLine($"Вы угадали {userName}! {userNumber} - загаданное число!");
            tryes++;    // Счетчик увеличивается, чтобы не выводить надпись Game Over в случае победы с поледней попытки)
            break;
        }
    }

    if (tryes == 0)
    {
        Console.WriteLine($"Попытки закончились! Game over!");
    }
}

int StartGame(int num)
{
    int tryes = 3;

    Console.WriteLine($"Привет! Давай сыграем в угадайку? Я загадаю число от {minNumber} до {maxNumber}, а ты его угадаешь!");
    Console.WriteLine($"Но помни, у тебя только {tryes} попытки. Поехали!");

    int number = new Random().Next(minNumber, maxNumber + 1);
    Console.WriteLine(number);  // Понятно, что пользователь не должен видеть загаданное число, но данная строка необходима для проверки.
    return number;
}

string UserName(string name)
{
    Console.WriteLine("Введите имя: ");
    string userName = Console.ReadLine();
    return userName;
}
