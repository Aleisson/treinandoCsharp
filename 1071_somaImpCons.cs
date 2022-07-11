using System;
public class Aleisson
{
    public static void Main()
    {

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int aux = 0;
        int impares = 0;

        if (x > y)
        {
            aux = x;
            x = y;
            y = aux;
        }
  
        for (int i = x + 1; i < y; i++)
        {
            
            if (i % 2 != 0)
            {
                impares+=i;
               
            }
            
            
        }

        System.Console.WriteLine(impares);


    }
}