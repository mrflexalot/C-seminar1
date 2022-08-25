//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""2, 4""
//M = 4; N = 8. -> ""4, 6, 8""
void Rec(int m, int n)
{
    n -= n % 2;
    if (n < m) return;
    Rec(m, n - 1);
    Console.Write($"{n}, ");
}
Console.Write("Enter the number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number N: ");
int n = int.Parse(Console.ReadLine());
Rec(m, n);