using System;

public class Aleisson
{
    public static void Main()
    {

        string[] pedido = Console.ReadLine().Split();
        int cod = Convert.ToInt32(pedido[0]);
        int qtd = Convert.ToInt32(pedido[1]);

        if (cod == 1)
        {
            System.Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", qtd * 4.00));
        }
        if (cod == 2)
        {
            System.Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", qtd * 4.50));
        }
        if (cod == 3)
        {
            System.Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", qtd * 5.00));
        }
        if (cod == 4)
        {
            System.Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", qtd * 2.00));
        }
        if (cod == 5)
        {
            System.Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", qtd * 1.50));
        }

    }
}