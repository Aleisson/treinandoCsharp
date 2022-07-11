using System;

public class Aleisson
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        string[] medias = { };
        double mediaP2 = 0;
        double mediaP3 = 0;
        double mediaP5 = 0;
        double[] total = new double[n];

        for (int i = 0; i < n; i++)
        {
            medias = Console.ReadLine().Split();
            mediaP2 = Convert.ToDouble(medias[0]);
            mediaP3 = Convert.ToDouble(medias[1]);
            mediaP5 = Convert.ToDouble(medias[2]);

            total[i] = (mediaP2 * 2 + mediaP3 * 3 + mediaP5 * 5)/10;
            
        }

        foreach (var item in total)
        {
            System.Console.WriteLine(string.Format("{0:0.0}",item));
        }

    }
}