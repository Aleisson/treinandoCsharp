using System;

public class Aleisson
{
    public static void Main()
    {
        string[] n = Console.ReadLine().Split();
        int a = Convert.ToInt32(n[0]);
        int b = Convert.ToInt32(n[1]);

        if (a % b == 0 || b % a == 0)
        {
            System.Console.WriteLine("Sao Multiplos");
        }
        else
        {
            System.Console.WriteLine("Nao sao Multiplos");
        }

    }
}