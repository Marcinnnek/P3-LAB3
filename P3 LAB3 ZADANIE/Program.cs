using System;
using System.Dynamic;

namespace P3_LAB3_ZADANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            TableSum();
        }

        static void TableSum()
        {
            Console.Write("Podaj pierwszy wymiar tablicy: ");
            int firstDimension = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugi wymiar tablicy: ");
            int secondDimension = int.Parse(Console.ReadLine());

            double[][] tablica = new double[firstDimension][];

            Random rnd = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = new double[secondDimension];
                //tablica[i] = new double[2];                   #test
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    //Console.WriteLine(tablica[i].Length);
                    tablica[i][j] = rnd.Next(100);
                    //tablica[i][j] = 10;                       #test
                }
            }

            double suma=0;

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    Console.WriteLine(suma);
                    suma += tablica[i][j];
                }
            }
            Console.WriteLine($"suma: {suma}");
        }
    }
}
