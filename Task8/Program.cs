﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N < 2)
{
    Console.WriteLine ("Вы ввели неверное значение. Введите значение больше 2");
}
for (int i = 2; i <= N; i+=2)
{
    Console.Write ($"{i} ");
}


