using System;

public class Aleisson
{

    public static void Main()
    {

        for (double i = 0; i <= 2; i += 0.2)
        {
            for (double j = 1 + i; j <= i + 3; j++)
            {
                System.Console.WriteLine($"I={i} J={j}");
            }
        }

    }

}