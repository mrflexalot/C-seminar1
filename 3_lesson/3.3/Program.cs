﻿double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 4);
}

Distance(3, 6, 2, 1);
Console.WriteLine(Distance(3, 6, 2, 1));