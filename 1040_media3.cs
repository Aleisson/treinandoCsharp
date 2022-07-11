using System;

public class Aleisson
{
    public static void Main()
    {


        string[] medias = Console.ReadLine().Split();
        double N1 = Convert.ToDouble(medias[0]);
        double N2 = Convert.ToDouble(medias[1]);
        double N3 = Convert.ToDouble(medias[2]);
        double N4 = Convert.ToDouble(medias[3]);

        double media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

        if (media >= 7)
        {
            System.Console.WriteLine("Media: " + string.Format("{0:0.0}", Math.Truncate(media * 10) / 10));
            System.Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            System.Console.WriteLine("Media: " + string.Format("{0:0.0}", Math.Truncate(media * 10) / 10));
            System.Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 5 && media < 7)
        {
            System.Console.WriteLine("Media: " + string.Format("{0:0.0}", Math.Truncate(media * 10) / 10));
            System.Console.WriteLine("Aluno em exame.");
            double exame = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Nota do exame: " + string.Format("{0:0.0}", Math.Truncate(exame * 10) / 10));
            media = (media + exame) / 2;
            if (media >= 5)
            {
                System.Console.WriteLine("Aluno aprovado.");
                System.Console.WriteLine("Media final: " + string.Format("{0:0.0}", Math.Truncate(media * 10) / 10));
            }
            else if (media < 5)
            {
                System.Console.WriteLine("Aluno reprovado.");
                System.Console.WriteLine("Media final: " + string.Format("{0:0.0}", Math.Truncate(media * 10) / 10));
            }
        }
    }
}