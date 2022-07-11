using System;

public class Aleisson
{
    public static void Main()
    {

        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= x; i++)
        {
            if (i % 2 != 0) System.Console.WriteLine(i);
        }

    }
}