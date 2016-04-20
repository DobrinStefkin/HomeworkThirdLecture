using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int divideByFive = number % 5;
        int divideBySeven = number % 7;
        if (divideByFive == 0 && divideBySeven == 0)
        {
            Console.WriteLine("true " + number);
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}
