using System;
    using System.Collections.Generic;

class Medii{

    public static double mediaGeometrica( int[] sir)
    {
        double prod = 1;
        for (int i = 0; i < sir.Length; i++)
        { prod=prod*sir[i]; }
        double medGeom=Math.Pow(prod,1.0/sir.Length);
        return medGeom;
    }

    public static double mediaAritmetica(int[] sir)
    {
        int suma = 0;
        for(int i = 0;i< sir.Length;i++)
        { suma = suma+sir[i]; }
        double medartm=(double)suma/sir.Length;
        return medartm;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("introduceti sirul de numere intregi la tastatura : ");
        string intrare=Console.ReadLine();
        string[] numere = intrare.Split(' ');

        int[] sir = new int[numere.Length];
        for (int i = 0; i<numere.Length; i++)
        { sir[i]=Convert.ToInt32(numere[i]); }
        
        double medGeom=Medii.mediaGeometrica(sir);
        double medArtm=Medii.mediaAritmetica(sir);

        Console.WriteLine($"Media geometrica= {medGeom}");
        Console.WriteLine($"media aritmetica= {medArtm}");
    }
}