using System;

public class Aleisson
{
    public static void Main()
    {
        string[] valores = Console.ReadLine().Split();
        int x = Convert.ToInt32(valores[0]);
        int y = Convert.ToInt32(valores[1]);


        while (x != 0 && y != 0)
        {

            if (x > 0 && y > 0)
            {
                System.Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0)
            {
                System.Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0)
            {
                System.Console.WriteLine("terceiro");
            }
            else
            {
                System.Console.WriteLine("quarto");
            }

            valores = Console.ReadLine().Split();
            x = Convert.ToInt32(valores[0]);
            y = Convert.ToInt32(valores[1]);
        }

    }
}