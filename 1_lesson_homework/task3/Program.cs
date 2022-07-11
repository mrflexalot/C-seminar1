//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Write a number N: ");
int N = int.Parse(Console.ReadLine());
int i=2;

Console.WriteLine("Your array of even numbers from 0 to N:");
while (i<=N)
    {
    Console.WriteLine(i);
    i+=2;
    }