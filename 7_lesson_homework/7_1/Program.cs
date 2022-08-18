﻿//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j],10} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(n_new.NextDouble() * (10 + 10) - 10, 2);
        }
    }
    return arr;
}

double[,] arr_1 = MassNums(5, 5, 1, 15);
Print(arr_1);