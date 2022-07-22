// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("enter a number to form a 3rd power list of it:");
int N = int.Parse(Console.ReadLine());
void result(int N)
{
    if (N < 1)
    {
        Console.WriteLine("Incorrect number");
        return;
    }
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
Console.WriteLine($"Your 3rd power list of number {N}:");
result(N);