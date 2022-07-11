using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int x = 0;


        for (int i = 0; i < n; i++)
        {
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 0) System.Console.WriteLine("NULL");

            if (x % 2 == 0 && x != 0)
            {
                if (x > 0) System.Console.WriteLine("EVEN POSITIVE");
                if (x < 0) System.Console.WriteLine("EVEN NEGATIVE");
            }
            if (x % 2 != 0)
            {
                if (x > 0) System.Console.WriteLine("ODD POSITIVE");
                if (x < 0) System.Console.WriteLine("ODD NEGATIVE");
            }




        }


    }
}