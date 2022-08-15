//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Intersection point: ({x}; {y})");
}
Console.Write("Enter b1 number :");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Enter k1 number :");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Enter b2 number :");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Enter k2 number :");
double k2 = int.Parse(Console.ReadLine());
Intersection(b1, k1, b2, k2);