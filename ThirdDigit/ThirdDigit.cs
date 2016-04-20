using System;

    class ThirdDigit
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        N /= 100;
        N %= 10;
        if (N == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + N);
        }
    }
}
