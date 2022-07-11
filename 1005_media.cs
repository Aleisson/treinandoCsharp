using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        double a = Math.Round(Convert.ToDouble(Console.ReadLine()),1);
        double b = Math.Round(Convert.ToDouble(Console.ReadLine()),1);
        
        Console.WriteLine("MEDIA = " +string.Format("{0:0.00000}",(a*3.5+b*7.5)/11));
    }
}
