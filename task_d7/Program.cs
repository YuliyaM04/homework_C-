// напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Последняя цифра: " + num % 10);
