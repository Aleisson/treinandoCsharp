using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        string cobaia = "";
        double totalCobaias = 0;
        double coelhos = 0;
        double ratos = 0;
        double sapos = 0;

        for (int i = 0; i < n; i++)
        {
            cobaia = Console.ReadLine();

            if (cobaia.IndexOf("C") > 0)
            {
                coelhos += Convert.ToDouble(cobaia.Substring(0, 2));
                totalCobaias += Convert.ToDouble(cobaia.Substring(0, 2));
            }

            if (cobaia.IndexOf("R") > 0)
            {
                ratos += Convert.ToDouble(cobaia.Substring(0, 2));
                totalCobaias += Convert.ToDouble(cobaia.Substring(0, 2));
            }

            if (cobaia.IndexOf("S") > 0)
            {
                sapos += Convert.ToDouble(cobaia.Substring(0, 2));
                totalCobaias += Convert.ToDouble(cobaia.Substring(0, 2));
            }

        }


        System.Console.WriteLine($"Total: {totalCobaias} cobaias");
        System.Console.WriteLine($"Total de coelhos: {coelhos}");
        System.Console.WriteLine($"Total de ratos: {ratos}");
        System.Console.WriteLine($"Total de sapos: {sapos}");
        System.Console.WriteLine($"Percentual de coelhos: {string.Format("{0:0.00}", (coelhos * 100) / totalCobaias)} %");
        System.Console.WriteLine($"Percentual de ratos: {string.Format("{0:0.00}", (ratos * 100) / totalCobaias)} %");
        System.Console.WriteLine($"Percentual de sapos: {string.Format("{0:0.00}", (sapos * 100) / totalCobaias)} %");

    }
}