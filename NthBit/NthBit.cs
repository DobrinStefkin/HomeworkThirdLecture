using System;

class NthBit
{
    static void Main()
    {
        long P = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long mask = 1;
        if ((0 <= N && N < 55) && (0 <= P && P <= (2^55))) //2^55 = 36028797018963968
        {
            Console.WriteLine((mask << N & P) == 0 ? "0" : "1");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
