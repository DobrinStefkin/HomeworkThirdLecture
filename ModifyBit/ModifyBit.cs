using System;

class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());
        if (0 <= P && P < 65)
        {
            if (V == 0)
            {
                ulong mask = (ulong)~(1 << P);
                ulong result = N & mask;
                Console.WriteLine(result);
            }
            else if (V == 1)
            {
                ulong mask = (ulong)1 << P;
                ulong result = N | mask;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
