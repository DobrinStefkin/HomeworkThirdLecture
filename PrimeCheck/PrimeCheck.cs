using System;

class PrimeCheck
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var isPrime = "true";
        if (1 < N && N <= 100)
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = "false"; 
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
