using System;

class FourDigits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        if (999 < n && n <= 9999)
        {
            uint d = n % 10;
            uint c = (n / 10) % 10;
            uint b = (n / 100) % 10;
            uint a = (n / 1000) % 10;
            uint sumOfDigits = a + b + c + d;
            Console.WriteLine(sumOfDigits);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

