// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int result(int a)
{
    return (((a % 100) - (a % 10)) / 10);
}
Console.WriteLine("enter 3-digit number");
int a = int.Parse(Console.ReadLine());
if (a < 1000 && a > 99)
{
        Console.WriteLine($"second digit of your number is: {result(a)}");
}
else
{
    Console.WriteLine($"{a} is not a 3-digit number!");
}