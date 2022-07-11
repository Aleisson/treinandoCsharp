using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10000; i++)
        {
            if (i % n == 2) System.Console.WriteLine(i);
        }

    }
}