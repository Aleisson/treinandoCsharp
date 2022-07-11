using System;

public class Aleisson
{
    public static void Main()
    {

        int j = 7;
        int i = 1;

        while (i < 10)
        {
            System.Console.WriteLine($"I={i} J={j}");
            j--;
            if (j < 5)
            {
                i += 2;
                j = 7;
            }


        }


    }
}