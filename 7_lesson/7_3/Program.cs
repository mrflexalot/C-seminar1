﻿// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}
int SumOfDiagonaile (int[,] arr)
{
    int count = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row < column)
    {
        column = row;
    }
    else if (column < row)
    {
        row = column;
    }
    for (int i = 0; i < row; i++)
    {
        count = count + arr[i, i];
    }
    return count;
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);

Console.WriteLine(SumOfDiagonaile(arr_1));
