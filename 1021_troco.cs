using System;

public class Aleisson
{
    public static void Main()
    {

        double valor = Convert.ToDouble(Console.ReadLine());

        int valorInt = Convert.ToInt32((Math.Truncate(valor)));

        int[] cedulas = { 100, 50, 20, 10, 5, 2 };

        int[] moedas = { 100, 50, 25, 10, 5, 1 };

        System.Console.WriteLine("NOTAS:");

        foreach (int item in cedulas)
        {
            Console.WriteLine(valorInt / item + " nota(s) de R$ " + string.Format("{0:0.00}", item));
            valorInt %= item;
            valor %= item;
        }

        valorInt = Convert.ToInt32(valor * 100);

        System.Console.WriteLine("MOEDAS:");

        foreach (int item in moedas)
        {
            Console.WriteLine(valorInt / item + " moeda(s) de R$ " + string.Format("{0:0.00}", Convert.ToDouble(item) / 100));
            valorInt %= item;


        }

    }
}
