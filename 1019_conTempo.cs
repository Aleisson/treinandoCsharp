using System;

public class Aleisson
{


    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int seg = n%60;
        int min = (n%3600)/60;
        int hora = n/(60*60);
        Console.WriteLine($"{hora}:{min}:{seg}");
        
    }


}