﻿// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

int a, b;
 
Console.WriteLine("Введите два числа : ");
 
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
 
if (a > b)
{
    Console.Write($"Большее число = {a}, Меньшее число = {b}");
}
else
{
    Console.Write($"Большее число = {b}, Меньшее число = {a}");
}
