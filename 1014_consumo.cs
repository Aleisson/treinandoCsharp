using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        int dist = Convert.ToInt32(Console.ReadLine());
        double gas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(string.Format("{0:0.000}", dist/gas) + " km/l");

    }
}
