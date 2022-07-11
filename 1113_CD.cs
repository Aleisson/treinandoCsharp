using System;

public class Aleisson
{
    static void Main()
    {

        string[] valores = Console.ReadLine().Split();
        int x = Convert.ToInt32(valores[0]);
        int y = Convert.ToInt32(valores[1]);

        while (x != y)
        {

            if (x > y)
            {
                System.Console.WriteLine("Decrescente");
            }
            else if (x < y)
            {
                System.Console.WriteLine("Crescente");
            }
            valores = Console.ReadLine().Split();
            x = Convert.ToInt32(valores[0]);
            y = Convert.ToInt32(valores[1]);

        }


    }
}