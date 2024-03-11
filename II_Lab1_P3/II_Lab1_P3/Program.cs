using System;
using System.Collections.Generic;
class Convertor
{
    public static double CtoF(double tempC) 
    {
        double tempF = (tempC * 9) / (5 + 32);
        return tempF;
        }

    public static double FtoC(double tempF)
    { double tempC = (tempF - 32) * 5 / 9;
        return tempC;
    }

    public static void Afisare(double rez)
    {
        Console.WriteLine($"Rezultatul conversiei este: {rez}");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Conversie din Celsius in Fahrenheit");
        Console.WriteLine("2. Conversie din Fahrenheit in Celsius");
        Console.WriteLine("Alegeti optiunea:");
        int optiune = Convert.ToInt32(Console.ReadLine());

        switch (optiune)
        {
            case 1:
                Console.WriteLine("Introduceti temperatura in grade Celsius:");
                double tempC = Convert.ToDouble(Console.ReadLine());
                double rezultatCtoF = Convertor.CtoF(tempC);
                Convertor.Afisare(rezultatCtoF);
                break;
            case 2:
                Console.WriteLine("Introduceti temperatura in grade Fahrenheit:");
                double tempF = Convert.ToDouble(Console.ReadLine());
                double rezultatFtoC = Convertor.FtoC(tempF);
                Convertor.Afisare(rezultatFtoC);
                break;
            default:
                Console.WriteLine("Optiune invalida!");
                break;
        }

        Console.ReadLine();
    }

}