// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckTheDay(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("этот день выходной => да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Такого дня не существует");
    }
    else Console.WriteLine("этот день выходной => нет");
}

CheckTheDay(dayNumber);
