using System;

public class Aleisson
{
    public static void Main()
    {
        string[] points = Console.ReadLine().Split();
        double A = Convert.ToDouble(points[0]);
        double B = Convert.ToDouble(points[1]);
        double C = Convert.ToDouble(points[2]);
        double AUX = 0;

        if (A < B)
        {
            AUX = A;
            A = B;
            B = AUX;
        }

        if (A < C)
        {
            AUX = A;
            A = C;
            C = AUX;
        }

        if (B < C)
        {
            AUX = B;
            B = C;
            C = AUX;
        }




        if (A >= B + C)
        {
            System.Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (A * A == B * B + C * C)
            {
                System.Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (A * A > B * B + C * C)
            {
                System.Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (A * A < B * B + C * C)
            {
                System.Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && A == C && B == C)
            {
                System.Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if ((A == B || (A == C) || B == C))
            {
                System.Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}