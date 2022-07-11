using System;

public class Aleisson
{


    public static void Main()
    {

        string[] letras = Console.ReadLine().Split();

        int A = Convert.ToInt32(letras[0]);
        int B = Convert.ToInt32(letras[1]);
        int C = Convert.ToInt32(letras[2]);
        int D = Convert.ToInt32(letras[3]);

        if ( B > C && D > A && C + D > A + B && C >= 0 && D >= 0 && A % 2 == 0)
        {
            System.Console.WriteLine("Valores aceitos");
        }else
        {
            System.Console.WriteLine("Valores nao aceitos");
        }


    }


}