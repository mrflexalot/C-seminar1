//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Enter number a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number b:");
int b = int.Parse(Console.ReadLine());
int exp (int a, int b)
{
    int degree = a;
    for (int i = 2; i <= b; i++)
    {
        degree = degree * a;
    }
    return degree;
}
Console.WriteLine($"Your exponentation result is {exp(a, b)}");