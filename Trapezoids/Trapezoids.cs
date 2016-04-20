using System;

class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        if ((-500 < a && a < 500) && (-500 < b && b < 500) && (-500 < h && h < 500))
        {
            double area = ((a + b) * h) / 2;
            Console.WriteLine("{0:0.0000000}", area);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
