//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("enter your number:");
int a = int.Parse(Console.ReadLine());
void result(int a)
{
    if (a < 100)
    {
        Console.WriteLine($"{a} has no third number!");
        return;
    }
    while (a > 999)
        a = a / 10;
    Console.WriteLine(a % 10);
}
result(a);