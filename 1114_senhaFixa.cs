using System;

public class Aleisson
{
    static void Main()
    {

        int senha = Convert.ToInt32(Console.ReadLine());

        while (senha != 2002)
        {
            System.Console.WriteLine("Senha Invalida");
            senha = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine("Acesso Permitido");

    }
}