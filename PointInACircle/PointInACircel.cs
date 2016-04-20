using System;

class PointInACircel
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 2;
        double distance = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
        if ((-1001 < x && x < 1001) && (-1001 < y && y < 1001))
        {
            if (((x * x) + (y * y)) <= radius * radius)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", distance);
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
