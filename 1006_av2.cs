using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        double a = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
        double b = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
        double c = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);

        Console.WriteLine("MEDIA = " + string.Format("{0:0.0}", (a * 2 + b * 3 + c * 5) / 10));
    }
}
