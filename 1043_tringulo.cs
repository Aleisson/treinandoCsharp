using System;

public class Aleisson
{
    public static void Main()
    {

        string[] pontosTring = Console.ReadLine().Split();

        double A = Convert.ToDouble(pontosTring[0]);
        double B = Convert.ToDouble(pontosTring[1]);
        double C = Convert.ToDouble(pontosTring[2]);

        if (A < B + C && B < A + C && C < A + B)
        {
            System.Console.WriteLine(string.Format("Perimetro = {0:0.0}", A + B + C));
        }
        else
        {
            System.Console.WriteLine(string.Format("Area = {0:0.0}", (A + B)*C/2 ));
        }


    }
}