using System;

public class Aleisson
{
    public static void Main()
    {


     string diaInicial = Console.ReadLine();
        int diaIncialInt = Convert.ToInt32(diaInicial.Substring(4));
        string horasInicial = Console.ReadLine();
        int Ihora = Convert.ToInt32(horasInicial.Substring(0,2));
        int Imin = Convert.ToInt32(horasInicial.Substring(5,2));
        int Iseg = Convert.ToInt32(horasInicial.Substring(10,2));
       
        string diafinal = Console.ReadLine();
        int diaFinalInt = Convert.ToInt32(diafinal.Substring(4));
        string horasFinal = Console.ReadLine();
        int Fhora = Convert.ToInt32(horasFinal.Substring(0,2));
        int Fmin = Convert.ToInt32(horasFinal.Substring(5,2));
        int Fseg = Convert.ToInt32(horasFinal.Substring(10,2));


        
        DateTime date1 = new DateTime(2008, 1, diaIncialInt, Ihora, Imin, Iseg);
        DateTime date2 = new DateTime(2008, 1, diaFinalInt, Fhora, Fmin, Fseg);
        TimeSpan dataTotal = date2.Subtract(date1);


        System.Console.WriteLine(dataTotal.Days + " dia(s)");
        System.Console.WriteLine(dataTotal.Hours + " hora(s)");
        System.Console.WriteLine(dataTotal.Minutes + " minuto(s)");
        System.Console.WriteLine(dataTotal.Seconds + " segundo(s)");


    }
}
/*Mono não aceita */

//    string diaInicial = Console.ReadLine();
//         int diaIncialInt = Convert.ToInt32(diaInicial.Substring(4));
//         string[] horasInicial = Console.ReadLine().Split(" : ");
//         int Ihora = Convert.ToInt32(horasInicial[0]);
//         int Imin = Convert.ToInt32(horasInicial[1]);
//         int Iseg = Convert.ToInt32(horasInicial[2]);

//         string diafinal = Console.ReadLine();
//         int diaFinalInt = Convert.ToInt32(diafinal.Substring(4));
//         string[] horasFinal = Console.ReadLine().Split(" : ");
//         int Fhora = Convert.ToInt32(horasFinal[0]);
//         int Fmin = Convert.ToInt32(horasFinal[1]);
//         int Fseg = Convert.ToInt32(horasFinal[2]);



//         DateTime date1 = new DateTime(2008, 1, diaIncialInt, Ihora, Imin, Iseg);
//         DateTime date2 = new DateTime(2008, 1, diaFinalInt, Fhora, Fmin, Fseg);
//         TimeSpan dataTotal = date2.Subtract(date1);


//         System.Console.WriteLine(dataTotal.Days + " dia(s)");
//         System.Console.WriteLine(dataTotal.Hours + " hora(s)");
//         System.Console.WriteLine(dataTotal.Minutes + " minuto(s)");
//         System.Console.WriteLine(dataTotal.Seconds + " segundo(s)");