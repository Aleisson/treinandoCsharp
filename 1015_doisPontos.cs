using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        string pontos1 = Console.ReadLine();
        string[] pontoXY1 = pontos1.Split();

        string pontos2 = Console.ReadLine();
        string[] pontoXY2 = pontos2.Split();

        double x1 = Convert.ToDouble(pontoXY1[0]);
        double y1 = Convert.ToDouble(pontoXY1[1]);
        double x2 = Convert.ToDouble(pontoXY2[0]);
        double y2 = Convert.ToDouble(pontoXY2[1]);

        double resultado = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

        Console.WriteLine(string.Format("{0:0.0000}", resultado));

    }
}
