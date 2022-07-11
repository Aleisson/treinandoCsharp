using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            System.Console.WriteLine($"{i} x {n} = {n*i}");
        }


    }
}