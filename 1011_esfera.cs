using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        double raio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("VOLUME = " + string.Format("{0:0.000}",(4.0/3.0)*3.14159*(raio*raio*raio)));
    }
}
