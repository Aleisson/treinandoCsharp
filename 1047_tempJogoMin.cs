using System;

public class Aleisson
{
    public static void Main()
    {

        string[] horas = Console.ReadLine().Split();
        double inicioHora = Convert.ToInt32(horas[0]);
        double inicioMin = Convert.ToInt32(horas[1]);
        double fimHora = Convert.ToInt32(horas[2]);
        double fimMin = Convert.ToInt32(horas[3]);

        double tempHora = (24 - (inicioHora + inicioMin/60)) + fimHora + (fimMin/60);
        double tempMin = (60 - inicioMin) + fimMin;

        if (tempHora > 24) tempHora = tempHora - 24;
        if (tempMin >=60) tempMin = tempMin - 60;
        
        System.Console.WriteLine($"O JOGO DUROU {Math.Truncate(tempHora)} HORA(S) E {tempMin} MINUTO(S)");



    }
}