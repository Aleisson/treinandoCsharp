using System;

public class Aleisson
{
    public static void Main()
    {

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) System.Console.WriteLine(i);
        }

    }
}
//usando Linq
//  foreach (int item in Enumerable.Range(1, 10).Where(x => x % 2 == 0))
//         {
//             System.Console.WriteLine(item);
//         }