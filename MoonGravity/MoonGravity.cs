using System;

class MoonGravity
{
    static void Main()
    {
        double W = double.Parse(Console.ReadLine());//W - weight of a man on Earth

        if (W < 0 || W >= 1000)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            double gEarth = 9.8;
            double weightOnEarth = W * gEarth;
            double gMoon = 0.17 * gEarth;
            double weightOnMoon = W * gMoon;
            double Z = weightOnMoon / gEarth;// Z - weight of a man on the Moon
            String s = string.Format("{0:0.000}", Z);
            Console.WriteLine(s);
        }
    }
}
