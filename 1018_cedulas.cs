using System;

public class Aleisson
{
    public static void Main()
    {

        int valor = Convert.ToInt16(Console.ReadLine());
      
        int[] cedulas = {100,50,20,10,5,2,1};

        Console.WriteLine(valor)

        foreach (int item in cedulas)
        {
            Console.WriteLine($"{valor/item} nota(s) de R$ {item},00");
            valor%=item;
        }


    }

}

  /*
        int cem = valor / 100;
        int cinq = (valor % 100) / 50;
        int vinte = (valor % 100 % 50) / 20;
        int dez = (valor % 100 % 50 % 20) / 10;
        int cinco = (valor % 100 % 50 % 20 % 10) / 5;
        int dois = (valor % 100 % 50 % 20 % 10 % 5) / 2;
        int um = (valor % 100 % 50 % 20 % 10 % 5 % 2) / 1;

        Console.WriteLine(valor);
        Console.WriteLine(cem + " nota(s) de R$ 100,00");
        Console.WriteLine(cinq + " nota(s) de R$ 50,00");
        Console.WriteLine(vinte + " nota(s) de R$ 20,00");
        Console.WriteLine(dez + " nota(s) de R$ 10,00");
        Console.WriteLine(cinco + " nota(s) de R$ 5,00");
        Console.WriteLine(dois + " nota(s) de R$ 2,00");
        Console.WriteLine(um + " nota(s) de R$ 1,00");
        */