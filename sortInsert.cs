using System;

public class Aleisson
{
    public static void Main()
    {

        string[] valores = Console.ReadLine().Split();
        int[] num = new int[3];

        for (int l = 0; l < valores.Length; l++)
        {
            num[l] = Convert.ToInt32(valores[l]);
        }


        int i, j, atual;
        for (i = 1; i < num.Length; i++)
        {
            atual = num[i];
            j = i;
            while ((j > 0) && (num[j - 1] > atual))
            {
                num[j] = num[j - 1];
                j = j - 1;
            }
            num[j] = atual;
        }

        foreach (var item in num)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine();

        foreach (var item in valores)
        {
            System.Console.WriteLine(item);
        }


    }
}
