int Method(int num)
{
    int AllSum = 1;
    for (int i = 1; i <= num; i++)
        AllSum = AllSum * i;
        return AllSum;
}
Console.WriteLine(Method(5));