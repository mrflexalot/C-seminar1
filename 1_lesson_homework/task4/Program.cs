//Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Write a number A: ");
int a = int.Parse(Console.ReadLine());

if (a >= 100) 
    {Console.WriteLine("the last number of A is:");
    Console.WriteLine(a%10);}
    
    else Console.WriteLine("invalid number");