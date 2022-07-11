using System;

public class Aleisson
{
    public static void Main()
    {
        int m = 1;
        int n = 1;
        string[] valores = { };
        string sequencia = "";
        int soma = 0;
        int aux = 0;
        string[] imprimir = { };

        while (m > 0 && n > 0)
        {

            valores = Console.ReadLine().Split();

            m = Convert.ToInt32(valores[0]);
            n = Convert.ToInt32(valores[1]);

            if (m > n)
            {
                aux = m;
                m = n;
                n = aux;
            }


            if (m > 0 && n > 0)
            {
                for (int i = m; i <= n; i++)
                {
                    sequencia += i + " ";
                    soma += i;
                }
                System.Console.WriteLine(sequencia + $"Sum={soma}");
            }


            soma = 0;
            sequencia = "";
        }

     
        
        
    }
}