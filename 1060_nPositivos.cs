using System;

public class Aleisson
{
    public static void Main()
    {

        double n = 0;
        int c = 0;      

        for (int i = 0; i < 6; i++)
        {
            n = Convert.ToDouble(Console.ReadLine());
            if (n > 0) c++;

        }

        System.Console.WriteLine(c + " valores positivos");
    }
}