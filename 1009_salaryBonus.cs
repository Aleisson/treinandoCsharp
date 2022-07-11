using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double salary = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
        double sales = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
        Console.WriteLine("TOTAL = R$ " + string.Format("{0:0.00}",salary + sales * 0.15));

    }
}
