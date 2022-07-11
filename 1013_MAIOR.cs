using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        string valor = Console.ReadLine();
        string[] valores = valor.Split();
        int A = Convert.ToInt16(valores[0]);
        int B = Convert.ToInt16(valores[1]);
        int C = Convert.ToInt16(valores[2]);

        int maiorA = (A + B + Math.Abs(A - B)) / 2;
        int maiorB = (maiorA + C + Math.Abs(maiorA - C)) / 2;

        Console.WriteLine(maiorB + " eh o maior");

    }
}
