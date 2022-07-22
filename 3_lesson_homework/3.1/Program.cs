// : Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
//палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("enter 5-digit number to check, if it's palindrome");
int a = int.Parse(Console.ReadLine());

void result(int a)
{
    if (a < 10000)
    {
        Console.WriteLine("Your number is not 5 digit");
        return;
    }
    if (a / 1000 == (a % 10) * 10 + (a % 100) / 10)
    {
        Console.WriteLine("Your number is palindrome");
    }

    else
    {
        Console.WriteLine("Your number is not palindrome");
    }
}
result(a);