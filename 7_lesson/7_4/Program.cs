﻿// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
//    выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
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
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
string FirstExposition(int[,] arr, int a)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == a)
                return $" {i + 1} {j + 1}";
        }
    }
    return "No";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);

Console.WriteLine("Enter the number ");
int b = int.Parse(Console.ReadLine());
Print(arr_1);
Console.WriteLine(FirstExposition(arr_1, b));