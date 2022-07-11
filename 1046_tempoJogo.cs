using System;

public class Aleisson
{
    public static void Main()
    {
        string[] horas = Console.ReadLine().Split();
        int inicio = Convert.ToInt32(horas[0]);
        int fim = Convert.ToInt32(horas[1]);

        if ((24 - inicio) + fim > 24)
        {
            System.Console.WriteLine($"O JOGO DUROU {((24 - inicio) + fim) - 24} HORA(S)");
        }
        else
        {
            System.Console.WriteLine($"O JOGO DUROU {(24 - inicio) + fim} HORA(S)");
        }

    }
}