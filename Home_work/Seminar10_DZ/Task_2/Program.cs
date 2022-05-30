// Задача 74*: 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка. До каждого бара идти примерно 15-20 минут, каждый 
// пьет пинту за 15 минут. У первого друга лимит выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо выяснить, до 
// скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. И сколько всего времени будет потрачено на выпивку.

const int timeDrink = 15;
const int timeWalk = 15;

const double pinta = 0.58;

const int countFriends = 4;
const int countBars = 12;

double[] friendsLimitVolumes = new double[countFriends] { 1.1, 1.5, 2.2, 3.3 };

double[] timeFriends = new double[countFriends] { 0, 0, 0, 0 };
double[] volumeFriends = new double[countFriends] { 0, 0, 0, 0 };
int[] friendsAlive = new int[countFriends] { 0, 0, 0, 0 };

for (int i = 0; i < countFriends; i++)
{
    for (int j = 0; j < countBars; j++)
    {
        if (friendsAlive[i] == 0) { timeFriends[i] += timeDrink; }
        if (friendsAlive[i] == 0)
        {
            if (volumeFriends[i] < friendsLimitVolumes[i]) { volumeFriends[i] += pinta; } else { friendsAlive[i] = j; }
        }
        if (friendsAlive[i] == 0) { timeFriends[i] += timeWalk; }
    }

}

Console.WriteLine("Затраченное время");
PrintArray(timeFriends);

for (int i = 0; i < friendsAlive.Length; i++)
{
    if (friendsAlive[i] == 0) { friendsAlive[i] = 11; }
}

Console.WriteLine("Пройденное расстояние (в барах)");
for (int i = 0; i < friendsAlive.Length; i++)
{
    Console.WriteLine($"Друг №{i + 1} - {friendsAlive[i]} ");
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($" Друг №{i + 1} - {array[i]} минут ");
    }
}
