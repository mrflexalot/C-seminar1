// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию
int SumNums(int sum)
{
    if (sum == 0) return 0;
    return SumNums(sum / 10) + sum % 10;
}
Console.WriteLine(SumNums(123));