using System;

public class Aleisson
{


    public static void Main()
    {


        int dias = Convert.ToInt32(Console.ReadLine());

        int ano = dias / 365;
        int mes = (dias % 365) / 30;
        int dia = (dias % 365 % 30);

        System.Console.WriteLine(ano + " ano(s)");
        System.Console.WriteLine(mes + " mes(es)");
        System.Console.WriteLine(dia + " dia(s)");

    }

}