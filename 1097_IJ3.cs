using System;

public class Aleisson
{
    public static void Main()
    {

        int aux = 7;
        for (int i = 1; i < 10; i+=2)
        {
            for (int j = aux; j > aux - 3; j--)
            {
                System.Console.WriteLine($"I={i} J={j}");
            }
            aux+=2;
         
        }



    }
}