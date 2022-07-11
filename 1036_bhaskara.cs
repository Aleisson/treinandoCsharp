using System;

public class Aleisson
{
    public static void Main()
    {


        string[] pontos = Console.ReadLine().Split();

        double A = Convert.ToDouble(pontos[0]);
        double B = Convert.ToDouble(pontos[1]);
        double C = Convert.ToDouble(pontos[2]);

        if ((B * B) - 4 * A * C > 0 && A != 0)
        {

            System.Console.WriteLine("R1 = " + String.Format("{0:0.00000}", (-B + Math.Sqrt((B * B) - 4 * A * C)) / (2 * A)));
            System.Console.WriteLine("R2 = " + String.Format("{0:0.00000}", (-B - Math.Sqrt((B * B) - 4 * A * C)) / (2 * A)));

        }
        else
        {
            System.Console.WriteLine("Impossivel calcular");
        }


    }
}