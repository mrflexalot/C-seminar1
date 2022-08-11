//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double[] RandomArray(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}
void Diff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        else if (min > arr[i])
        {
            min = arr[i];
        }
    }
    Console.Write($"max: {max}, min: {min}");
    Console.WriteLine($"Difference: {max} - ({min}) = {Math.Round(max - min, 2)}");
}
double[] arr = RandomArray(10);
Print(arr);
Diff(arr);