﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

if (a < b)
    Console.WriteLine("number b is greater than number a");

if (a > b)
    Console.WriteLine("number a is greater than number b");

if (a == b)
    Console.WriteLine("Numbers are equal");