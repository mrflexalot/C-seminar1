﻿// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void Ism(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)

        arr[i] = arr[i] * -1;

}

int[] arr_1 = MassNums(12, -9, 10);
Print(arr_1);
Ism(arr_1);
Print(arr_1);