using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int nOut = 0;
        int nIn = 0;
        int aux = 0;

        for (int i = 0; i < n; i++)
        {
            aux = Convert.ToInt32(Console.ReadLine());
            if (aux >= 10 && aux<= 20)
            {
                nIn++;
            }
            else
            {
                nOut++;
            }

        }

        System.Console.WriteLine(nIn + " in");
        System.Console.WriteLine(nOut + " out");
    }
}