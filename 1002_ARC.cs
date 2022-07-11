using System;

//importante essa questão foi dificil
public class Aleisson
{
    public static void Main(string[] args)
    {
      
       double raio =  Convert.ToDouble(Console.ReadLine());
       double resultado =  3.14159 * (raio*raio);
      
       Console.WriteLine("A=" + string.Format("{0:0.0000}", resultado));

    }
}
