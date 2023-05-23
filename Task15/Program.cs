// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
System.Console.WriteLine("Введите номер дня недели от 1 до 7 ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5)
    System.Console.WriteLine("БУДНИЙ ДЕНЬ ");
else if (x == 6 || x == 7)
    System.Console.WriteLine("ВЫХОДНОЙ ");
else 
    System.Console.WriteLine("Неправельный номер ");