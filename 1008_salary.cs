using System;

public class Aleisson
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt16(Console.ReadLine());
        int month = Convert.ToInt16(Console.ReadLine());
        decimal hourPay = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("NUMBER = " + num);
        Console.WriteLine("SALARY = U$ " + month * hourPay);

    }
}
