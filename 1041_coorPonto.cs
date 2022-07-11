using System;

public class Aleisson
{
    public static void Main()
    {

        string[] pontos = Console.ReadLine().Split();

        double x = Convert.ToDouble(pontos[0]);
        double y = Convert.ToDouble(pontos[1]);

        if (x == 0 && y == 0)
        {
            System.Console.WriteLine("Origem");
        }
        else if (x == 0 && y != 0)
        {
            System.Console.WriteLine("Eixo Y");
        }
        else if (x != 0 && y == 0)
        {
            System.Console.WriteLine("Eixo X");
        }
        else if (x > 0 && y > 0)
        {
            System.Console.WriteLine("Q1");
        }
        else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Q2");
        }
        else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("Q3");
        }
        else
        {
            System.Console.WriteLine("Q4");
        }

    }
}