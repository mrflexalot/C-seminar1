//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
string Find(int[,] arr, int row_num, int column_num)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row_num > row || row_num <= 0 || column_num > column || column_num <= 0)
        return $"{row_num}, {column_num} -> not found";
    return $"arr[{row_num}, {column_num}] = {arr[row_num - 1, column_num - 1]} -> found in array";
}
Console.Write("Enter the row position: ");
int row_num = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int column_num = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(5, 5, 1, 15);
Print(arr_1);
Console.Write(Find(arr_1, row_num, column_num));