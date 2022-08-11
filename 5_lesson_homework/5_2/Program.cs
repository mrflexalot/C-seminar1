//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 89, 6] -> 0
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int[] RandomArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}
int OddNumSum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}
int[] arr = RandomArray(10, 1, 100);
Print(arr);
Console.WriteLine($"Your odd numbers sum is: {OddNumSum(arr)}");