using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        string enterOne = Console.ReadLine();
        string enterTwo = Console.ReadLine();
        string[] pieceOne = enterOne.Split();
        string[] pieceTwo = enterTwo.Split();
        double priceOne = Convert.ToDouble(pieceOne[1]) * Convert.ToDouble(pieceOne[2]);
        double priceTwo = Convert.ToDouble(pieceTwo[1]) * Convert.ToDouble(pieceTwo[2]);
        Console.WriteLine("VALOR A PAGAR: R$ " + string.Format("{0:0.00}", priceOne + priceTwo));
    }
}