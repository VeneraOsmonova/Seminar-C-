﻿/*1. Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго. 
a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет*/

System.Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
