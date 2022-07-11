using System;

public class Aleisson
{

    public static void Main()
    {

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((string.Format("{0:0.000}",(a*b)/12)));
    }

}