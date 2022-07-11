using System;

public class Aleisson
{

    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int x, y, aux, impares = 0;
        string[] num = { };
        int[] valores = new int[n];

        for (int i = 0; i < n; i++)
        {
            num = Console.ReadLine().Split();
            x = Convert.ToInt32(num[0]);
            y = Convert.ToInt32(num[1]);

            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }


            for (int j = x + 1; j < y; j++)
            {
                if (j % 2 != 0) impares += j;
            }
            valores[i] = impares;
            impares = 0;

        }

        foreach (int item in valores)
        {
            System.Console.WriteLine(item);
        }

    }

}