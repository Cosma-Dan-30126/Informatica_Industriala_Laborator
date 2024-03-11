using System;
using System.Collections.Generic;

class Calculator
{
    public static double Sumator( double a, double b)
    { return a + b; }

    public static double Scazator( double a, double b)
    { return a - b; }

    public static double Inmultire(double a, double b)
        { return a * b; }

    public static double Impartire(double a, double b)
    {
        if (b == 0) { throw new ArgumentException("Numar ce nu poate fi formatat."); }
        return a / b;

    }

    public static void Afisare(double rezultat)
    {
        Console.WriteLine("Rezultatul dat de calcul este=  " + rezultat);
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primul numar este: ");
        double n1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Al 2 lea numar este: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double suma=Calculator.Sumator(n1, n2);
        Calculator.Afisare(suma);

        double scaderea=Calculator.Scazator(n1, n2);
        Calculator.Afisare(scaderea);

        double inmultire=Calculator.Inmultire(n1, n2);
        Calculator.Afisare(inmultire);

        double impartire=Calculator.Impartire(n1, n2);
        Calculator.Afisare(impartire);

        Console.ReadLine();


    }
}