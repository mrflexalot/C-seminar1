//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int Sum(int m, int n)
{
    if (m == n) return n;
    return Sum(m, n - 1) + n;

}
Console.Write("Enter the number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(m, n));