using System;
public class Aleisson
{
    public static void Main()
    {

        string[] animais = new string[3];

        animais[0] = Console.ReadLine();
        animais[1] = Console.ReadLine();
        animais[2] = Console.ReadLine();

        if (animais[0] == "vertebrado")
        {
            if (animais[1] == "ave")
            {
                if (animais[2] == "carnivoro")
                {
                    System.Console.WriteLine("aguia");
                }
                if (animais[2] == "onivoro")
                {
                    System.Console.WriteLine("pomba");
                }
            }
            if (animais[1] == "mamifero")
            {
                if (animais[2] == "onivoro")
                {
                    System.Console.WriteLine("homem");
                }
                if (animais[2] == "herbivoro")
                {
                    System.Console.WriteLine("vaca");
                }
            }
        }
        if (animais[0] == "invertebrado")
        {
            if (animais[1] == "inseto")
            {
                if (animais[2] == "hematofago")
                {
                    System.Console.WriteLine("pulga");
                }
                if (animais[2] == "herbivoro")
                {
                    System.Console.WriteLine("lagarta");
                }
            }
            if (animais[1] == "anelideo")
            {
                if (animais[2] == "hematofago")
                {
                    System.Console.WriteLine("sanguessuga");
                }
                if (animais[2] == "onivoro")
                {
                    System.Console.WriteLine("minhoca");
                }
            }
        }

    }
}