using System;

public class Aleisson
{
    public static void Main()
    {
        double n = 0;
        int c = 0;
        double soma = 0;

        for (int i = 0; i < 6; i++)
        {
            n = Convert.ToDouble(Console.ReadLine());
            if (n > 0)
            {
                c++;
                soma += n;
            }

        }

        System.Console.WriteLine(c + " valores positivos");
        System.Console.WriteLine(string.Format("{0:0.0}", soma / c));
    }
}