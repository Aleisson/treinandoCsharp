using System;

public class Aleisson
{
    public static void Main()
    {

        string[] numeros = Console.ReadLine().Split();

        int m1 = Convert.ToInt32(numeros[0]);
        int m2 = Convert.ToInt32(numeros[1]);
        int m3 = Convert.ToInt32(numeros[2]);

        int aux = 0;

        if (m1 > m2)
        {
            aux = m1;
            m1 = m2;
            m2 = aux;
        }


        if (m1 > m3)
        {
            aux = m1;
            m1 = m3;
            m3 = aux;
        }


        if (m2 > m3)
        {
            aux = m2;
            m2 = m3;
            m3 = aux;
        }



        System.Console.WriteLine(m1);
        System.Console.WriteLine(m2);
        System.Console.WriteLine(m3);
        System.Console.WriteLine();
        foreach (var item in numeros)
        {
            System.Console.WriteLine(item);
        }
    }
}
