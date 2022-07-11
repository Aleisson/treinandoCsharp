using System;

public class Aleisson
{
    public static void Main()
    {

        double salario = Convert.ToDouble(Console.ReadLine());

        if (salario > 0 && salario <= 400)
        {
            System.Console.WriteLine($"Novo salario: {string.Format("{0:0.00}", salario + salario * 0.15)}");
            System.Console.WriteLine($"Reajuste ganho: {string.Format("{0:0.00}", salario * 0.15)}");
            System.Console.WriteLine("Em percentual: 15 %");
        }
        if (salario > 400 && salario <= 800)
        {
            System.Console.WriteLine($"Novo salario: {string.Format("{0:0.00}", salario + salario * 0.12)}");
            System.Console.WriteLine($"Reajuste ganho: {string.Format("{0:0.00}", salario * 0.12)}");
            System.Console.WriteLine("Em percentual: 12 %");
        }
        if (salario > 800 && salario <= 1200)
        {
            System.Console.WriteLine($"Novo salario: {string.Format("{0:0.00}",salario + salario * 0.1)}");
            System.Console.WriteLine($"Reajuste ganho: {string.Format("{0:0.00}",salario * 0.1)}");
            System.Console.WriteLine("Em percentual: 10 %");
        }
        if (salario > 1200 && salario <= 2000)
        {
            System.Console.WriteLine($"Novo salario: {string.Format("{0:0.00}",salario + salario * 0.07)}");
            System.Console.WriteLine($"Reajuste ganho: {string.Format("{0:0.00}",salario * 0.07)}");
            System.Console.WriteLine("Em percentual: 7 %");
        }
        if (salario > 2000)
        {
            System.Console.WriteLine($"Novo salario: {string.Format("{0:0.00}",salario + salario * 0.04)}");
            System.Console.WriteLine($"Reajuste ganho: {string.Format("{0:0.00}",salario * 0.04)}");
            System.Console.WriteLine("Em percentual: 4 %");
        }


    }
}