using System;
using System.Collections.Generic;

class GreutateId
{
    public static int GreutateMen(int h,int v, char gen) 
    {
  
        int greutateIdeala = h - 100-((h-150)/4)+((v-20)/4);
        return greutateIdeala;
    }

    public static double GreutateWomen(double h, double v, char gen)
    {

        double greutateIdeala = h - 100 - ((h - 150) / 2.5) + ((v - 20) / 6);
        return greutateIdeala;
    }

    public static void AfisareGreutate(double greutateIdeala, char gen) 
    {
        if (gen == 'm')
        { Console.WriteLine($"Greutatea perfecta pentru barbati este= {greutateIdeala} kg"); }
        else if (gen == 'f')
        { Console.WriteLine($"Greutatea perfecta pentru femei este= {greutateIdeala} kg"); }
        else
            Console.WriteLine("Ceva nu a fost introdus corect! Incercati din nou.");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scrieti la tastatura inatimea actuala in cm : ");
        int h=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Scrieti la tastatura varsta dumneavoastra in ani : ");
        int v=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti la tastatura sexul dumneavoastra(m sau f) : ");
        char gen =Convert.ToChar(Console.ReadLine());

        double greutateIdeala = 0;
        //Urmeaza sa fie facuta selectia si sa ne folosim de clasa GreutateId
            if(gen=='m')
        { greutateIdeala = GreutateId.GreutateMen(h, v, gen); }
            else if (gen=='f')
        { greutateIdeala = GreutateId.GreutateWomen(h, v, gen); }
        GreutateId.AfisareGreutate(greutateIdeala, gen);
    }
}