using System;

public class Aleisson
{
    public static void Main()
    {

        int i = 0;
        int x = Convert.ToInt32(Console.ReadLine());

        while (i < 6)
        {
            if (x % 2 != 0)
            {
                i++;
                System.Console.WriteLine(x);
            }
            x++;
        }

    }
}