using System;

class OddOrEven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            if (n < -30 || n > 30)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine("even " + n);
            }
        }
        else
        {
            if (n < -30 || n > 30)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine("odd " + n);
            }
        }
    }
}
