using System;

public class Aleisson
{
    public static void Main()
    {

        double salario = Convert.ToDouble(Console.ReadLine());
       

        if (salario > 0 && salario < 2000)
        {
            System.Console.WriteLine("Isento");
        }
        else if (salario > 2000 && salario <= 3000)
        {
            System.Console.WriteLine(string.Format("R$ {0:0.00}", (salario - 2000) * 0.08));
        }
        else if (salario > 3000 && salario <= 4500)
        {
            System.Console.WriteLine(string.Format("R$ {0:0.00}", ((salario - 3000) * 0.18 + 80)));
        }
        else if (salario > 4500 )
        {
            System.Console.WriteLine(string.Format("R$ {0:0.00}", ((salario - 4500) * 0.28 + 350)));
        }


    }
}