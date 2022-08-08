//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Enter the number:");
int n = int.Parse(Console.ReadLine());
int Sum(int n)
{
    int n_sum = 0;
    for (int i = n; n != 0; n /= 10)
    {
        n_sum += n % 10;
    }
    return n_sum;
}
Console.WriteLine(Sum(n));