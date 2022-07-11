using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        string[] valores = { };
        double x = 0;
        double y = 0;

        for (int i = 0; i < n; i++)
        {
            valores = Console.ReadLine().Split();
            x = Convert.ToInt32(valores[0]);
            y = Convert.ToInt32(valores[1]);

            if (y == 0)
            {
                System.Console.WriteLine("divisao impossivel");
            }
            else
            {
                System.Console.WriteLine(string.Format("{0:0.0}", x / y));
            }
    

        }

    }
}