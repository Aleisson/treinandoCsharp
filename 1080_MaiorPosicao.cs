using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int posicao = 1;
        int maior = n;

        for (int i = 2; i <= 5; i++)
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (maior < n)
            {
                maior = n;
                posicao = i;

            }
        }

        System.Console.WriteLine(maior);
        System.Console.WriteLine(posicao);

    }
}