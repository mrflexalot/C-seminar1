//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("enter the number from 1 to 7 to check if it's a weekend or not:");
int a = int.Parse(Console.ReadLine());
if (a > 7)
{
    Console.WriteLine("Error");
}
else if (a > 5 )
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
