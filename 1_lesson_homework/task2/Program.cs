﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

if (a%2==0)
    Console.WriteLine("number a is even");
else Console.WriteLine("number a is odd");