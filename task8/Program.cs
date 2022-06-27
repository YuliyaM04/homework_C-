// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (num < N)
{
if (num % 2 == 0)
{
    Console.Write(num + " ");
}
num = num + 1;
}