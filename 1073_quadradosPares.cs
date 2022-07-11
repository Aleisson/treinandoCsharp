using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine($"{i}^2 = {i*i}");
            }
        }

    }
}