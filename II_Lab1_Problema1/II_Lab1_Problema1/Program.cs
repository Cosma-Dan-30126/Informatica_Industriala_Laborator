using System;

    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dati valoarea n de parametri care vor fi afisati de firul Fibonacci: ");
        int n = Convert.ToInt32(Console.ReadLine()) ;
        int f0 = 0;
        int f1 = 1;
        for(int i=2;i<=n;i++)
        {
            int fn = f0 + f1;
            Console.Write(fn + " ");
            f0 = f1;
            f1 = fn;
        }
        Console.ReadLine();
    }
}

