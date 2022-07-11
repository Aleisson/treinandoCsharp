using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        string valores = Console.ReadLine();
        string[] pontos = valores.Split();
        double A = Convert.ToDouble(pontos[0]);
        double B = Convert.ToDouble(pontos[1]);
        double C = Convert.ToDouble(pontos[2]);
        Console.WriteLine("TRIANGULO: " + string.Format("{0:0.000}", (A * C) / 2));
        Console.WriteLine("CIRCULO: " + string.Format("{0:0.000}", (3.14159 * (C * C))));
        Console.WriteLine("TRAPEZIO: " + string.Format("{0:0.000}", ((A + B) * C) / 2));
        Console.WriteLine("QUADRADO: " + string.Format("{0:0.000}", B * B));
        Console.WriteLine("RETANGULO: " + string.Format("{0:0.000}", A * B));

    }
}
