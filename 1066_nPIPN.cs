using System;

public class Aleisson
{
    public static void Main()
    {
        double n = 0;
        int par = 0;
        int impar = 0;
        int positivo = 0;
        int negativo = 0;

        for (int i = 0; i < 5; i++)
        {
            n = Convert.ToDouble(Console.ReadLine());
            if (n % 2 == 0)
            {
                par++;
            }
            if (n % 2 != 0)
            {
                impar++;
            }
            if (n > 0)
            {
                positivo++;
            }
            if (n < 0)
            {
                negativo++;
            }
        }
        System.Console.WriteLine(par + " valor(es) par(es)");
        System.Console.WriteLine(impar + " valor(es) impar(es)");
        System.Console.WriteLine(positivo + " valor(es) positivo(s)");
        System.Console.WriteLine(negativo + " valor(es) negativo(s)");

    }
}