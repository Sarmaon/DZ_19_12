// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)

    number = number % 10;
    Console.Write("Третья цифра числа = ");
    Console.Write(number);

while(number > 1000)
{
    number = number / 10 % 100;
    Console.WriteLine("Третьей цифры нет");
}


