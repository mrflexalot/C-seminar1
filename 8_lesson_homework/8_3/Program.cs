﻿//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] Multiply(int[,] arr1, int[,] arr2)
{
    int row_size1 = arr1.GetLength(0);
    int column_size1 = arr1.GetLength(1);
    int row_size2 = arr2.GetLength(0);
    int column_size2 = arr2.GetLength(1);
    int[,] result = new int[row_size1, column_size2];
    if (column_size1 != row_size2)
        Console.Write("Impossible");
    else

        for (int i = 0; i < row_size1; i++)
        {
            for (int j = 0; j < column_size2; j++)
            {
                for (int k = 0; k < column_size1; k++)
                {
                    result[i, j] += (arr1[i, k] * arr2[k, j]);
                }
            }
        }
    return (result);
}

int[,] arr1 = MassNums(2, 3, 1, 10);
Print(arr1);
int[,] arr2 = MassNums(3, 2, 1, 10);
Print(arr2);
int[,] arr3 = Multiply(arr1, arr2);
Print(arr3);