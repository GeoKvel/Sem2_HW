﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
System.Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
x = x / 10;
x = x % 10;
System.Console.WriteLine(x);