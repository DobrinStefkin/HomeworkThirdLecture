using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        bool isInCircle = (Math.Abs(x - 1)) * (Math.Abs(x - 1)) + (Math.Abs(y - 1)) * (Math.Abs(y - 1)) <= radius * radius;
        bool isInRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);
        if ((-1001 < x && x < 1001) && (-1001 < y && y < 1001))
        {
            if (isInCircle && isInRectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (isInCircle && !isInRectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (!isInCircle && isInRectangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}