// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
System.Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
if (x >= 100)
{
    while (x > 1000)
        x = x / 10;
    x = x % 10;
    System.Console.WriteLine(x);
}
else System.Console.WriteLine("Третьей цифры нет ");